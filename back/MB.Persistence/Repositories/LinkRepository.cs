using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
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
                   .FirstOrDefaultAsync(link => link.EntityId == linkId)
                   ?? throw new NotFoundException("Link not found.");

        var existingCategoryIds = link.LinkCategories?.Select(relation => relation.LinkCategoryId).ToList() ?? [];

        var categoriesToAdd = categoryIds.Except(existingCategoryIds).ToList();
        var relationsToAdd = categoriesToAdd.Select(categoryId => new RelationLinkCategory
        {
            LinkId = linkId,
            LinkCategoryId = categoryId
        }).ToList();

        _context.RLinkCategory.AddRange(relationsToAdd);

        var categoriesToRemove = existingCategoryIds.Except(categoryIds).ToList();
        var relationsToRemove = link.LinkCategories?.Where(relation => categoriesToRemove.Contains(relation.LinkCategoryId)).ToList();

        if (relationsToRemove != null && relationsToRemove.Count != 0)
        {
            _context.RLinkCategory.RemoveRange(relationsToRemove);
        }

        await _context.SaveChangesAsync();
    }
}