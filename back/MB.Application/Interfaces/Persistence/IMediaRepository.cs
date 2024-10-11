using MB.Application.Features.Medias.Queries;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;

namespace MB.Application.Interfaces.Persistence;

public interface IMediaRepository : IBaseRepository<Media>
{
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds);
    Task<IEnumerable<GetMediaCheckBoxesByFranchiseQueryDto>> GetCheckBoxesByFranchise(int franchiseId);
}