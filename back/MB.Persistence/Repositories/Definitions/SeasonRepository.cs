using MB.Application.Interfaces.Persistence.Definitions;
using MB.Domain.SeasonAggregate;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories.Definitions;

public class SeasonRepository(Context context) : BaseRepository<Season>(context), ISeasonRepository
{
    public Task<Season?> GetCurrentSeasonAsync(DateTime now) =>
        _context.Seasons
                .Where(s => s.StartsAt <= now && s.EndsAt >= now)
                .OrderByDescending(s => s.StartsAt)
                .FirstOrDefaultAsync();
}