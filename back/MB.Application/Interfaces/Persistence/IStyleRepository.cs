using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Styles.Queries.GetStylesCheck;
using MB.Domain.Entities;

namespace MB.Application.Contracts.Persistence;

public interface IStyleRepository : IBaseRepository<Style>
{
    System.Threading.Tasks.Task DeleteArtists(int styleId);
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds);
    Task<List<GetStylesCheckQueryDto>> GetStylesWithCheck(Guid artistId);
}