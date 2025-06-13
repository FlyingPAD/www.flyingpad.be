using System.Linq.Expressions;
using MB.Application.Interfaces.Persistence.Definitions;
using MB.Domain.SeasonAggregate;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories.Definitions;

public class SeasonRepository(Context context)
    : BaseRepository<Season>(context), ISeasonRepository
{
    public Task<Season?> GetCurrentSeasonAsync(DateTime now) =>
        _context.Seasons
                .AsNoTracking()
                .Where(s => s.StartsAt <= now && s.EndsAt >= now)
                .OrderByDescending(s => s.StartsAt)
                .FirstOrDefaultAsync();

    public async Task<IEnumerable<Season>> GetAllAsync(
        Expression<Func<Season, object>>? orderBy = null,
        bool ascending = true)
    {
        IQueryable<Season> query = _context.Seasons.AsNoTracking();

        if (orderBy is not null)
            query = ascending
                ? query.OrderBy(orderBy)
                : query.OrderByDescending(orderBy);

        return await query.ToListAsync();
    }

    public async Task CreateSeasonAsync(Season season)
    {
        // 1) Détache toutes les entités Season déjà dans le ChangeTracker
        foreach (var entry in _context.ChangeTracker.Entries<Season>().ToList())
            entry.State = EntityState.Detached;

        // 2) Ajoute et sauve
        _context.Seasons.Add(season);
        await _context.SaveChangesAsync();

        // 3) Détache la vôtre
        _context.Entry(season).State = EntityState.Detached;
    }

    public async Task UpdateSeasonAsync(Season season)
    {
        // 1) Détache toutes les entités Season déjà dans le ChangeTracker
        foreach (var entry in _context.ChangeTracker.Entries<Season>().ToList())
            entry.State = EntityState.Detached;

        // 2) Attache/Modifie et sauve
        _context.Seasons.Update(season);
        await _context.SaveChangesAsync();

        // 3) Détache la vôtre
        _context.Entry(season).State = EntityState.Detached;
    }
}