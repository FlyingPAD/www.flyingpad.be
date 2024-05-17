using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;

namespace MB.Application.Contracts.Persistence;

public interface ILinkCategoryRepository : IBaseRepository<LinkCategory>
{
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds);
}
