using MB.Application.Features.LinkCategories.Queries.GetLinkCategoriesCheckBoxesByLink;
using MB.Application.Interfaces.Persistence;
using MB.Domain.LinkCategoryAggregate;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories;

public class LinkCategoryRepository(Context context) : BaseRepository<LinkCategory>(context), ILinkCategoryRepository
{
    public async Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds)
    {
        return await _context.LinkCategories
                    .Where(category => businessIds.Contains(category.BusinessId))
                    .Select(category => category.EntityId)
                    .ToListAsync();
    }

    public async Task<IEnumerable<GetLinkCategoriesCheckBoxesByLinkQueryDto>> GetCheckBoxesByLink(int linkId)
    {
        var categories = await _context.LinkCategories
            .Select(category => new GetLinkCategoriesCheckBoxesByLinkQueryDto
            {
                BusinessId = category.BusinessId,
                Name = category.Name,
                IsChecked = category.RLinkCategories != null && category.RLinkCategories
                    .Any(relation => relation.LinkId == linkId)
            })
            .OrderBy(category => category.Name)
            .ToListAsync();

        return categories;
    }
}