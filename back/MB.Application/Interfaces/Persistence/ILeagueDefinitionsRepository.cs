using MB.Domain.LeagueAggregate;

namespace MB.Application.Interfaces.Persistence;

public interface ILeagueDefinitionsRepository : IBaseRepository<LeagueDefinition>
{
    Task<LeagueDefinition?> GetByOrderAsync(int order);
}