using MB.Domain.AchievementAggregate;

namespace MB.Application.Interfaces.Persistence.Definitions;

public interface IAchievementDefinitionsRepository : IBaseRepository<AchievementDefinition>
{
    Task<IList<AchievementDefinition>> GetByBusinessIdsAsync(IEnumerable<Guid> businessIds);
    Task<AchievementDefinition?> GetByCodeAsync(string code);
    Task<IList<AchievementDefinition>> GetByCodesAsync(IEnumerable<string> codes);
}