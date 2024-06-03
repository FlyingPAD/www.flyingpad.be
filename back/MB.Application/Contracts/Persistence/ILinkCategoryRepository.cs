using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.LinkCategories.Queries.GetLinkCategoriesCheckBoxesByLink;
using MB.Domain.Entities;

namespace MB.Application.Contracts.Persistence;

public interface ILinkCategoryRepository : IBaseRepository<LinkCategory>
{
    Task<IEnumerable<GetLinkCategoriesCheckBoxesByLinkQueryDto>> GetCheckBoxesByLink(int linkId);
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds);
}
