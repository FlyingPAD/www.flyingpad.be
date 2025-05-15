using MB.Application.Interfaces.Persistence;
using MB.Domain.UserAggregate;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories.Definitions;

public class UserRepository(Context context) : BaseRepository<User>(context), IUserRepository
{
    public Task<User?> GetByEmailAsync(string email) =>
        _context.Users.FirstOrDefaultAsync(u => u.Email == email);

    public Task<User?> GetByIdAsync(int id) =>
        _context.Users.SingleOrDefaultAsync(u => u.EntityId == id);

    public async Task<IList<User>> GetAllWithAchievementsAsync() =>
        await _context.Users
                      .Include(u => u.Achievements)
                      .ToListAsync();

    public async Task<User?> GetByBusinessIdWithAchievementsAsync(Guid businessId) =>
        await _context.Users
                      .Include(u => u.Achievements)
                        .ThenInclude(ua => ua.Definition)
                      .SingleOrDefaultAsync(u => u.BusinessId == businessId);

    public async Task<IList<User>> GetAllWithLeagueAsync()
    {
        return await _context.Users
                             .Include(u => u.LeagueDefinition)
                             .ToListAsync();
    }

    public async Task<User?> GetByBusinessIdFullAsync(Guid businessId)
    {
        return await _context.Users
            .Include(u => u.Achievements)
                .ThenInclude(ua => ua.Definition)
            .Include(u => u.Season)
            .Include(u => u.LeagueDefinition)
            .SingleOrDefaultAsync(u => u.BusinessId == businessId);
    }

    public async Task UpdateAggregateAsync(User user)
    {
        // 1) On « nettoie » tout ce qui était tracké avant
        _context.ChangeTracker.Clear();

        // 2) On attache l'utilisateur (et tout ce que vous voulez persister)
        _context.Users.Update(user);

        // 3) On sauvegarde
        await _context.SaveChangesAsync();
    }

    public async Task<IList<User>> GetAllFullAsync() =>
    await _context.Users
        .AsNoTracking()
        .Include(u => u.Achievements)
        .Include(u => u.Season)
        .Include(u => u.LeagueDefinition)
        .ToListAsync();

    public async Task<IReadOnlyList<User>> GetByLeagueDefinitionIdAsync(int leagueDefinitionId, CancellationToken ct = default)
    {
        return await _context.Set<User>()
                             .AsNoTracking()
                             .Where(u => u.LeagueDefinitionId == leagueDefinitionId)
                             .OrderByDescending(u => u.SeasonScore)
                             .ToListAsync(ct);
    }

    public async Task<IList<int>> GetAllUserIdsAsync()
    {
        // On ne charge que l’ID, pas tout le graphe
        return await _context.Users
            .Select(u => u.EntityId)
            .ToListAsync();
    }

    public async Task<User?> GetByIdFullAsync(int id)
    {
        return await _context.Users
            .Include(u => u.Achievements).ThenInclude(ua => ua.Definition)
            .Include(u => u.Season)
            .Include(u => u.LeagueDefinition)
            .SingleOrDefaultAsync(u => u.EntityId == id);
    }
}