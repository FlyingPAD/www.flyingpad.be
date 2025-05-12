using MB.Application.Interfaces.Persistence;
using MB.Domain.LeagueAggregate;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories.Definitions;

public class LeagueDefinitionsRepository(Context context) : BaseRepository<LeagueDefinition>(context), ILeagueDefinitionsRepository
{
    public async Task<LeagueDefinition?> GetByOrderAsync(int order)
    {
        return await _context.Set<LeagueDefinition>()
                             .AsNoTracking()  // Important: n'évite pas de suivre l'entité
                             .Where(l => l.Order == order)
                             .FirstOrDefaultAsync();
    }

    public async Task UpdateLeagueDefinitionAsync(LeagueDefinition leagueDefinition)
    {
        // Si l'entité est déjà suivie, on la détache avant de la réutiliser
        var entry = _context.Entry(leagueDefinition);

        if (entry.State == EntityState.Detached)
        {
            // Si l'entité est détachée, il n'y a rien à faire ici
            return;
        }

        // Si l'entité est suivie, on la détache pour éviter les conflits
        if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
        {
            _context.Entry(leagueDefinition).State = EntityState.Detached;
        }

        // Mettre à jour l'entité
        _context.Set<LeagueDefinition>().Update(leagueDefinition);
        await _context.SaveChangesAsync();
    }
}