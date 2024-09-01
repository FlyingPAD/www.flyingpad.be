using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;

namespace MB.Application.Contracts.Persistence;

public interface IMediaRepository : IBaseRepository<Media>
{
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds);
}
