using MB.Domain.AchievementAggregate;

namespace MB.Application.Interfaces.Persistence;

public interface IAchievementDefinitionsRepository : IBaseRepository<AchievementDefinition>
{
    Task<IList<AchievementDefinition>> GetByBusinessIdsAsync(IEnumerable<Guid> businessIds);
}