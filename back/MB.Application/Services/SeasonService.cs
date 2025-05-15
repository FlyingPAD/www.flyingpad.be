using System.Diagnostics;
using MB.Application.Interfaces.Persistence;
using MB.Application.Interfaces.Services;
using MB.Domain.AchievementAggregate;
using MB.Domain.SeasonAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MB.Application.Services;

public class SeasonService(
    ISeasonRepository seasonRepo,
    IUserRepository userRepo,
    ILeagueDefinitionsRepository leagueRepo,
    IAchievementDefinitionsRepository achievementDefRepo,
    ILevelDefinitionRepository levelDefRepo,
    ILogger<SeasonService> logger) : ISeasonService
{
    private readonly ISeasonRepository _seasonRepo = seasonRepo;
    private readonly IUserRepository _userRepo = userRepo;
    private readonly ILeagueDefinitionsRepository _leagueRepo = leagueRepo;
    private readonly IAchievementDefinitionsRepository _achievementDefRepo = achievementDefRepo;
    private readonly ILevelDefinitionRepository _levelDefRepo = levelDefRepo;
    private readonly ILogger<SeasonService> _logger = logger;

    public async Task ProcessSeasonsAsync()
    {
        var totalSw = Stopwatch.StartNew();
        var now = DateTime.UtcNow;
        _logger.LogInformation("=== Début ProcessSeasonsAsync à {Time:O} ===", now);

        // 1) Charger ou créer la saison initiale
        var sw1 = Stopwatch.StartNew();
        var seasons = (await _seasonRepo.GetAllAsync(orderBy: s => s.StartsAt, ascending: false)).ToList();
        var isFirst = !seasons.Any();
        var last = isFirst
            ? await CreateInitialSeasonAsync(now)
            : seasons.First();
        sw1.Stop();
        _logger.LogInformation(
            "Étape 1 terminée en {Elapsed} ms — saisons en base : {Count}, saison en cours : Id={Id} [{Starts}→{Ends}]",
            sw1.ElapsedMilliseconds, seasons.Count, last.EntityId, last.StartsAt, last.EndsAt);

        // 2) Préchargement des lookups
        var sw2 = Stopwatch.StartNew();
        var leagues = await (await _leagueRepo.GetAllAsync(orderBy: l => l.Order, ascending: true))
            .AsNoTracking()
            .ToListAsync();
        var levelDefs = (await _levelDefRepo.GetAllAsync()).ToList();
        var levelCodes = levelDefs.Select(ld => AchievementCodes.LevelReached(ld.LevelNumber));
        var leagueCodes = new[]
        {
            AchievementCodes.WoodLeague,
            AchievementCodes.StoneLeague,
            AchievementCodes.BronzeLeague,
            AchievementCodes.SilverLeague,
            AchievementCodes.CrystalLeague,
            AchievementCodes.EliteLeague,
            AchievementCodes.ChampionLeague,
            AchievementCodes.LegendLeague
        };
        var allCodes = levelCodes.Concat(leagueCodes);
        var allDefs = await _achievementDefRepo.GetByCodesAsync(allCodes);
        var defsByCode = allDefs.ToDictionary(d => d.Code);
        sw2.Stop();
        _logger.LogInformation(
            "Étape 2 terminée en {Elapsed} ms — {LeagueCount} ligues, {LevelCount} niveaux, {AchCount} succès chargés",
            sw2.ElapsedMilliseconds, leagues.Count, levelDefs.Count, defsByCode.Count);

        // 3) Snapshot des utilisateurs
        var sw3 = Stopwatch.StartNew();
        var userIds = await _userRepo.GetAllUserIdsAsync();
        sw3.Stop();
        _logger.LogInformation(
            "Étape 3 terminée en {Elapsed} ms — {UserCount} utilisateurs à traiter",
            sw3.ElapsedMilliseconds, userIds.Count);

        // 4) Traitement par utilisateur
        var sw4 = Stopwatch.StartNew();
        int promotions = 0, failures = 0;
        foreach (var userId in userIds)
        {
            try
            {
                var u = await _userRepo.GetByIdFullAsync(userId);
                if (u == null)
                {
                    _logger.LogWarning("Utilisateur introuvable : Id={UserId}", userId);
                    failures++;
                    continue;
                }

                var currentOrder = u.LeagueDefinition?.Order ?? 0;
                var score = u.SeasonScore;
                var nextLeague = leagues
                    .SingleOrDefault(l => l.Order == currentOrder + 1 && score >= l.MinExperience);

                _logger.LogDebug(
                    "User {UserId}: score={Score}, ligActuelle={Order}, seuilProchaine={Min}",
                    userId, score, currentOrder,
                    leagues.FirstOrDefault(l => l.Order == currentOrder + 1)?.MinExperience);

                if (nextLeague != null)
                {
                    _logger.LogInformation(
                        "Promotion candidate → User {UserId}: {Order}→{NextOrder}",
                        userId, currentOrder, nextLeague.Order);

                    u.UpdateLeague(nextLeague);

                    var code = leagueCodes[nextLeague.Order - 1];
                    if (defsByCode.TryGetValue(code, out var achDef))
                    {
                        u.UnlockAchievement(achDef);
                        _logger.LogInformation(
                            "Succès {Code} débloqué pour user {UserId}", code, userId);
                    }

                    u.ResetSeasonScore();
                    _logger.LogInformation("SeasonScore réinitialisé pour user {UserId}", userId);

                    await _userRepo.UpdateAggregateAsync(u);
                    promotions++;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erreur lors du traitement de l’utilisateur {UserId}", userId);
                failures++;
            }
        }

        sw4.Stop();
        _logger.LogInformation(
            "Étape 4 terminée en {Elapsed} ms — promotions={Promotions}, échecs={Failures}",
            sw4.ElapsedMilliseconds, promotions, failures);

        // 5) Clôturer la saison
        var sw5 = Stopwatch.StartNew();
        last.Close(now);
        await _seasonRepo.UpdateAsync(last);
        sw5.Stop();
        _logger.LogInformation(
            "Étape 5 terminée en {Elapsed} ms — saison {SeasonId} fermée à {Time:O}",
            sw5.ElapsedMilliseconds, last.EntityId, now);

        // 6) Créer la nouvelle saison
        var sw6 = Stopwatch.StartNew();
        var nextSunday = GetNextSundayAt2359(now);
        var newName = isFirst ? "Saison initiale" : $"Saison du {now:dd/MM/yyyy}";
        var newSeason = new Season(newName, now, nextSunday);
        await _seasonRepo.CreateAsync(newSeason);
        sw6.Stop();
        _logger.LogInformation(
            "Étape 6 terminée en {Elapsed} ms — nouvelle saison Id={Id} [{Starts}→{Ends}]",
            sw6.ElapsedMilliseconds, newSeason.EntityId, newSeason.StartsAt, newSeason.EndsAt);

        // 7) Ré-associer les utilisateurs
        var sw7 = Stopwatch.StartNew();
        foreach (var userId in userIds)
        {
            var u = await _userRepo.GetByIdFullAsync(userId);
            if (u == null) continue;
            u.ParticipateInSeason(newSeason);
            await _userRepo.UpdateAggregateAsync(u);
        }
        sw7.Stop();
        _logger.LogInformation(
            "Étape 7 terminée en {Elapsed} ms — ré-association terminée",
            sw7.ElapsedMilliseconds);

        _logger.LogInformation(
            "=== Fin ProcessSeasonsAsync en {TotalElapsed} ms ===", totalSw.ElapsedMilliseconds);
    }

    private async Task<Season> CreateInitialSeasonAsync(DateTime now)
    {
        var end = GetNextSundayAt2359(now);
        var season = new Season("Saison initiale", now, end);
        _logger.LogInformation("Création saison initiale : {Starts}→{Ends}", now, end);
        await _seasonRepo.CreateAsync(season);
        return season;
    }

    private static DateTime GetNextSundayAt2359(DateTime from)
    {
        int days = ((int)DayOfWeek.Sunday - (int)from.DayOfWeek + 7) % 7;
        var sunday = from.Date.AddDays(days <= 0 ? days + 7 : days);
        return new DateTime(sunday.Year, sunday.Month, sunday.Day, 23, 59, 59, DateTimeKind.Utc);
    }
}