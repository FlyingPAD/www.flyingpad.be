using MB.Application.Interfaces.Persistence;
using MB.Application.Interfaces.Services;
using MB.Domain.LeagueAggregate;
using MB.Domain.SeasonAggregate;

namespace MB.Application.Services;

public class SeasonService(
    IBaseRepository<Season> seasonRepo,
    IUserRepository userRepo,
    IBaseRepository<LeagueDefinition> leagueRepo) : ISeasonService
{
    private readonly IBaseRepository<Season> _seasonRepo = seasonRepo ?? throw new ArgumentNullException(nameof(seasonRepo));
    private readonly IUserRepository _userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
    private readonly IBaseRepository<LeagueDefinition> _leagueRepo = leagueRepo ?? throw new ArgumentNullException(nameof(leagueRepo));

    public async Task ProcessSeasonsAsync()
    {
        // 1) Récupérer toutes les saisons et prendre la plus récente
        var seasons = await _seasonRepo.GetAllAsync(orderBy: s => s.StartsAt, ascending: false);
        var lastSeason = seasons.FirstOrDefault();

        // 2) Si la dernière saison est terminée, on la clôture…
        if (lastSeason != null && lastSeason.EndsAt <= DateTime.UtcNow)
        {
            // Charger les users + leurs achievements
            var users = await _userRepo.GetAllWithAchievementsAsync();
            var leagues = await _leagueRepo.GetAllAsync();

            // Clôture métier
            lastSeason.CloseSeason(users, leagues);

            // Puis, pour chaque user, on recalcule sa ligue et on sauvegarde
            foreach (var u in users)
            {
                var league = leagues
                    .Where(l => l.MinExperience <= u.Experience
                             && (l.MaxExperience == null || u.Experience <= l.MaxExperience))
                    .OrderBy(l => l.Order)
                    .First();

                u.UpdateLeague(league);
                await _userRepo.UpdateAsync(u);
            }
        }

        // 3) Créer la nouvelle saison (prochain lundi 00:00 → dimanche 23:59:59)
        var today = DateTime.UtcNow.Date;
        var daysToMon = ((int)DayOfWeek.Monday - (int)today.DayOfWeek + 7) % 7;
        var nextMonday = today.AddDays(daysToMon);

        var newSeason = new Season(
            name: $"Saison du {nextMonday:dd/MM/yyyy}",
            startsAt: nextMonday,
            endsAt: nextMonday.AddDays(6).AddHours(23).AddMinutes(59).AddSeconds(59)
        );

        await _seasonRepo.CreateAsync(newSeason);
    }
}