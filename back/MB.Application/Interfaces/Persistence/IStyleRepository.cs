using MB.Application.Features.Styles.Queries.GetStylesCheck;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;

namespace MB.Application.Interfaces.Persistence;

public interface IStyleRepository : IBaseRepository<Style>
{
    System.Threading.Tasks.Task DeleteStyleRelations(int styleId);
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds);
    Task<List<GetStylesCheckQueryDto>> GetStylesWithCheck(Guid artistId);
}