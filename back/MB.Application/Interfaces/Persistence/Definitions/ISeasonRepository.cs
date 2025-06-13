using System.Linq.Expressions;
using MB.Domain.SeasonAggregate;

namespace MB.Application.Interfaces.Persistence.Definitions;

public interface ISeasonRepository : IBaseRepository<Season>
{
    Task CreateSeasonAsync(Season season);
    Task UpdateSeasonAsync(Season season);
    Task<IEnumerable<Season>> GetAllAsync(Expression<Func<Season, object>>? orderBy = null, bool ascending = true);
    Task<Season?> GetCurrentSeasonAsync(DateTime now);
}