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
}