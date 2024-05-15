using MB.Application.Contracts.Persistence;
using MB.Domain.Common;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="context"></param>
    public class LinkRepository(Context context) : BaseRepository<Link>(context), ILinkRepository
    {

        /// <summary>
        /// Get Links by Category
        /// </summary>
        /// <param name="linkCategoryId"></param>
        /// <returns>Links by Category</returns>
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
                // if 'abc' is null
                linksContainingAbc = [];
            }

            return linksContainingAbc;
        }

        /// <summary>
        /// Get Page of Links Containing ' ABC '
        /// </summary>
        /// <param name="abc"></param>
        /// <returns>Links List</returns>
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

    }
}
