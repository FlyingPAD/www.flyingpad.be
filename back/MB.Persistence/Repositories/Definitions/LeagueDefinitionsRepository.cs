using MB.Application.Interfaces.Persistence;
using MB.Domain.LeagueAggregate;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories.Definitions;

public class LeagueDefinitionsRepository(Context context) : BaseRepository<LeagueDefinition>(context), ILeagueDefinitionsRepository
{
    public async Task<LeagueDefinition?> GetByOrderAsync(int order)
    {
        return await _context.Set<LeagueDefinition>()
                             .AsNoTracking()
                             .Where(l => l.Order == order)
                             .FirstOrDefaultAsync();
    }

    public async Task UpdateLeagueDefinitionAsync(LeagueDefinition leagueDefinition)
    {
        var entry = _context.Entry(leagueDefinition);

        if (entry.State == EntityState.Detached)
        {
            return;
        }

        if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
        {
            _context.Entry(leagueDefinition).State = EntityState.Detached;
        }

        _context.Set<LeagueDefinition>().Update(leagueDefinition);
        await _context.SaveChangesAsync();
    }

    public async Task<LeagueDefinition?> GetByNameAsync(string name, CancellationToken ct = default)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Le nom de la ligue est requis", nameof(name));

        return await _context.Set<LeagueDefinition>()
                    .AsNoTracking()
                    .FirstOrDefaultAsync(l => l.Name == name, ct);
    }
}