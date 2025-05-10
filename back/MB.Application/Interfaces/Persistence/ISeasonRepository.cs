using MB.Domain.SeasonAggregate;

namespace MB.Application.Interfaces.Persistence;

public interface ISeasonRepository : IBaseRepository<Season>
{
    Task<Season?> GetCurrentSeasonAsync(DateTime now);
}