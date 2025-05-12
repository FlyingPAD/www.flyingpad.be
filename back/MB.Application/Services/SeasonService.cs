using MB.Application.Interfaces.Persistence;
using MB.Application.Interfaces.Services;
using MB.Domain.AchievementAggregate;
using MB.Domain.LeagueAggregate;
using MB.Domain.SeasonAggregate;
using MB.Domain.UserAggregate;
using Microsoft.Extensions.Logging;

namespace MB.Application.Services;

public class SeasonService(
    ISeasonRepository seasonRepo,
    IUserRepository userRepo,
    ILeagueDefinitionsRepository leagueRepo,
    IAchievementDefinitionsRepository achievementDefRepo,
    ILevelDefinitionRepository levelDefRepo,
    ILogger<SeasonService> logger
) : ISeasonService
{
    private readonly ISeasonRepository _seasonRepo = seasonRepo;
    private readonly IUserRepository _userRepo = userRepo;
    private readonly ILeagueDefinitionsRepository _leagueRepo = leagueRepo;
    private readonly IAchievementDefinitionsRepository _achievementDefRepo = achievementDefRepo;
    private readonly ILevelDefinitionRepository _levelDefRepo = levelDefRepo;
    private readonly ILogger<SeasonService> _logger = logger;

    public async Task ProcessSeasonsAsync()
    {
        _logger.LogInformation("Début du traitement des saisons à {Time}", DateTime.UtcNow);
        var now = DateTime.UtcNow;

        // 1) Charger ou créer la saison initiale
        var seasons = (await _seasonRepo.GetAllAsync(orderBy: s => s.StartsAt, ascending: false)).ToList();
        var lastSeason = seasons.FirstOrDefault()
                         ?? await CreateInitialSeasonAsync(now);

        // 2) Clôture de la saison & promotions
        _logger.LogInformation("Étape 1 : clôture de la saison et traitement des promotions.");

        var users = (await _userRepo.GetAllFullAsync()).ToList();
        var leagues = (await _leagueRepo.GetAllAsync()).ToList();
        var levelDefs = (await _levelDefRepo.GetAllAsync()).ToList();

        // Précharger définitions de succès de niveau
        var levelCodes = levelDefs.Select(ld => AchievementCodes.LevelReached(ld.LevelNumber)).ToList();
        var levelAchDefs = await _achievementDefRepo.GetByCodesAsync(levelCodes);

        foreach (var u in users)
        {
            var currentOrder = u.LeagueDefinition?.Order ?? 0;
            _logger.LogDebug("User {UserId}: SeasonScore={Score}, Ligue actuelle={Order}, Niveau={Level}",
                u.EntityId, u.SeasonScore, currentOrder, u.Level);

            // Recherche de la ligue suivante accessible
            var candidate = leagues
                .Where(l => l.Order > currentOrder && u.SeasonScore >= l.MinExperience)
                .OrderBy(l => l.Order)
                .FirstOrDefault();

            if (candidate != null)
            {
                // Promotion
                _logger.LogInformation(
                    "Promotion de l'utilisateur {UserId} de la ligue {Current} vers {Next}.",
                    u.EntityId, currentOrder, candidate.Order);

                u.UpdateLeague(candidate);
                await UnlockLeagueAchievementAsync(u, candidate);

                // Seuls les promus remettent leur score à zéro
                u.ResetSeasonScore();
                _logger.LogDebug("SeasonScore réinitialisé pour l'utilisateur {UserId}.", u.EntityId);
            }
            else
            {
                _logger.LogInformation(
                    "Utilisateur {UserId} non promu, conserve SeasonScore={Score} et ligue={Order}.",
                    u.EntityId, u.SeasonScore, currentOrder);
            }

            // Recalcul du niveau + déblocage du succès de niveau si nécessaire
            u.RecalculateLevel(
                levelDefs,
                AchievementCodes.LevelReached,
                code => levelAchDefs.SingleOrDefault(a => a.Code == code)
            );

            // Persiste les changements pour cet utilisateur
            await _userRepo.UpdateAggregateAsync(u);
            _logger.LogInformation(
                "Utilisateur {UserId} mis à jour en base (LigueId={League}, Niveau={Level}, SeasonScore={Score}).",
                u.EntityId, u.LeagueDefinitionId, u.Level, u.SeasonScore);
        }

        // 3) Création de la nouvelle saison
        _logger.LogInformation("Étape 2 : création de la nouvelle saison.");
        var newSeason = lastSeason.EndsAt > now
            ? new Season($"Saison démarrée le {now:dd/MM/yyyy}", now, lastSeason.EndsAt)
            : new Season($"Saison du {now:dd/MM/yyyy}", now, now.AddDays(7));

        await _seasonRepo.CreateAsync(newSeason);
        _logger.LogInformation("Nouvelle saison créée : {SeasonId}", newSeason.EntityId);

        // 4) Association de tous les utilisateurs à la nouvelle saison
        _logger.LogInformation("Étape 3 : association des utilisateurs à la nouvelle saison.");
        foreach (var u in users)
        {
            u.ParticipateInSeason(newSeason);
            await _userRepo.UpdateAggregateAsync(u);
            _logger.LogDebug(
                "Utilisateur {UserId} associé à la saison {SeasonId}.",
                u.EntityId, newSeason.EntityId);
        }

        _logger.LogInformation("Fin du traitement des saisons à {Time}", DateTime.UtcNow);
    }

    private async Task<Season> CreateInitialSeasonAsync(DateTime now)
    {
        var season = new Season("Saison Initiale", now, now.AddDays(7));
        await _seasonRepo.CreateAsync(season);
        _logger.LogInformation("Saison initiale créée : {SeasonId}", season.EntityId);
        return season;
    }

    private async Task UnlockLeagueAchievementAsync(User u, LeagueDefinition league)
    {
        var code = league.Order switch
        {
            1 => AchievementCodes.WoodLeague,
            2 => AchievementCodes.StoneLeague,
            3 => AchievementCodes.BronzeLeague,
            4 => AchievementCodes.SilverLeague,
            5 => AchievementCodes.CrystalLeague,
            6 => AchievementCodes.EliteLeague,
            7 => AchievementCodes.ChampionLeague,
            8 => AchievementCodes.LegendLeague,
            _ => null
        };

        if (code != null)
        {
            var def = await _achievementDefRepo.GetByCodeAsync(code);
            if (def != null)
            {
                u.UnlockAchievement(def);
                _logger.LogInformation(
                    "Succès de ligue {Code} débloqué pour l'utilisateur {UserId}.",
                    code, u.EntityId);
            }
        }
    }
}