using MB.Application.Features.LinkCategories.Queries.GetLinkCategoriesCheckBoxesByLink;
using MB.Domain.LinkCategoryAggregate;

namespace MB.Application.Interfaces.Persistence.Definitions;

public interface ILinkCategoryRepository : IBaseRepository<LinkCategory>
{
    Task<IEnumerable<GetLinkCategoriesCheckBoxesByLinkQueryDto>> GetCheckBoxesByLink(int linkId);
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds);
}
