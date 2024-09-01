using MB.Application.Contracts.Persistence;
using MB.Domain.Common;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories;

public class LinkRepository(Context context) : BaseRepository<Link>(context), ILinkRepository
{
    public async Task<List<Link>> GetLinksListByCategory(int? linkCategoryId)
    {
        List<Link> linksByCategory;

        linksByCategory = await _context.Links
            .Where(link =>
                link.LinkCategories != null &&
                link.LinkCategories.Any(relation => relation.LinkCategoryId == linkCategoryId))
            .OrderBy(link => link.Name)
            .ToListAsync();

        return linksByCategory;
    }

    public async Task<List<Link>> GetLinksContainingAbc(string? abc)
    {
        List<Link> linksContainingAbc;

        if (abc != null)
        {
            linksContainingAbc = await _context.Links
                .Where(link => link.Name.Contains(abc))
                .ToListAsync();
        }
        else
        {
            linksContainingAbc = [];
        }

        return linksContainingAbc;
    }

    public async Task<PaginationCursor<Link>> GetPageLinksContainingAbc(string abc, Guid startId, int pageSize, bool isFirstItem)
    {
        IQueryable<Link> query = _context.Links
            .Where(link => link.Name.Contains(abc));

        query = query.OrderBy(link => link.EntityId.ToString());

        if (!isFirstItem)
        {
            query = query.Where(link => link.EntityId.ToString().CompareTo(startId.ToString()) > 0);
        }
        else
        {
            query = query.Where(link => link.EntityId.ToString().CompareTo(startId.ToString()) >= 0);
        }

        var items = await query.Take(pageSize).ToListAsync();

        var response = new PaginationCursor<Link>
        {
            Entities = items,
            TotalItems = query.Count(),
            ItemPosition = items.FindIndex(link => link.BusinessId == startId)
        };

        return response;
    }

    public async System.Threading.Tasks.Task UpdateCategories(int linkId, ICollection<int> categoryIds)
    {
        var link = await _context.Links
                                 .Include(link => link.LinkCategories)
                                 .FirstOrDefaultAsync(link => link.EntityId == linkId) ?? throw new ArgumentException("No link found with the provided ID.", nameof(linkId));

        var existingCategoryIds = link.LinkCategories?.Select(relation => relation.LinkCategoryId).ToList() ?? [];

        var categoriesToAdd = categoryIds.Except(existingCategoryIds).ToList();
        foreach (var categoryId in categoriesToAdd)
        {
            _context.RLinkCategory.Add(new RelationLinkCategory { LinkId = linkId, LinkCategoryId = categoryId });
        }

        var categoriesToRemove = existingCategoryIds.Except(categoryIds).ToList();
        foreach (var categoryId in categoriesToRemove)
        {
            var categoryToRemove = link.LinkCategories?.FirstOrDefault(relation => relation.LinkCategoryId == categoryId);
            if (categoryToRemove != null)
                _context.RLinkCategory.Remove(categoryToRemove);
        }

        await _context.SaveChangesAsync();
    }
}
