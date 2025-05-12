using MB.Application.Interfaces.Persistence;
using MB.Domain.AchievementAggregate;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories.Definitions;

public class AchievementDefinitionsRepository(Context context) : BaseRepository<AchievementDefinition>(context), IAchievementDefinitionsRepository
{
    public async Task<IList<AchievementDefinition>> GetByBusinessIdsAsync(IEnumerable<Guid> businessIds)
    {
        return await _context.Set<AchievementDefinition>()
                             .Where(d => businessIds.Contains(d.BusinessId))
                             .ToListAsync();
    }

    public async Task<AchievementDefinition?> GetByCodeAsync(string code)
    {
        return await _context.Set<AchievementDefinition>()
                             .FirstOrDefaultAsync(a => a.Code == code);
    }

    public async Task<IList<AchievementDefinition>> GetByCodesAsync(IEnumerable<string> codes)
    {
        return await _context.Set<AchievementDefinition>()
                             .Where(a => codes.Contains(a.Code))
                             .ToListAsync();
    }
}