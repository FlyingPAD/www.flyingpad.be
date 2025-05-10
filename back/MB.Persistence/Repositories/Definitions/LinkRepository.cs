using MB.Application.Interfaces.Persistence;
using MB.Domain;
using MB.Domain.LinkAggregate;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories.Definitions;

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

    public async Task<Link?> GetLinkWithCategoriesAsync(int linkId)
    {
        return await _context.Links
            .Include(link => link.LinkCategories)
            .FirstOrDefaultAsync(link => link.EntityId == linkId);
    }

    public async Task RemoveLinkCategoriesAsync(Link link)
    {
        _context.RLinkCategory.RemoveRange(link.LinkCategories ?? []);
        await _context.SaveChangesAsync();
    }

    public async Task AddLinkCategoriesAsync(int linkId, IEnumerable<int> categoryIds)
    {
        var relationsToAdd = categoryIds.Select(categoryId => new RelationLinkCategory
        {
            LinkId = linkId,
            LinkCategoryId = categoryId
        }).ToList();

        _context.RLinkCategory.AddRange(relationsToAdd);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Link>> GetLinksByModel(int modelId)
    {
        return await _context.Links
            .Where(link => link.LinkModels != null && link.LinkModels
            .Any(relation => relation.ModelId == modelId))
            .OrderBy(link => link.Name)
            .ToListAsync();
    }

    public async Task<IEnumerable<Link>> GetLinksByArtist(int artistId)
    {
        return await _context.Links
            .Where(link => link.LinkArtists != null && link.LinkArtists
            .Any(relation => relation.ArtistId == artistId))
            .OrderBy(link => link.Name)
            .ToListAsync();
    }
}