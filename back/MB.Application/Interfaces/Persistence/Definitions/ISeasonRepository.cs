using MB.Domain.SeasonAggregate;

namespace MB.Application.Interfaces.Persistence.Definitions;

public interface ISeasonRepository : IBaseRepository<Season>
{
    Task<Season?> GetCurrentSeasonAsync(DateTime now);
}