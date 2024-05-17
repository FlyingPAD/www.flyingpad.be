using MB.Application.Contracts.Persistence;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories;

public class LinkCategoryRepository(Context context) : BaseRepository<LinkCategory>(context), ILinkCategoryRepository
{
    /// <summary>
    /// Gets the primary IDs by business IDs.
    /// </summary>
    public async Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds)
    {
        return await _context.LinkCategories
                             .Where(category => businessIds.Contains(category.BusinessId))
                             .Select(category => category.EntityId)
                             .ToListAsync();
    }
}
