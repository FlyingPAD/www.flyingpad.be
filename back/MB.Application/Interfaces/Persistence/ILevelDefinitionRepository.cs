using MB.Domain.LevelAggregate;

namespace MB.Application.Interfaces.Persistence;

public interface ILevelDefinitionRepository : IBaseRepository<LevelDefinition>
{
    Task<IList<LevelDefinition>> GetAllAsync();
    Task<LevelDefinition?> GetByLevelNumberAsync(int levelNumber);
}