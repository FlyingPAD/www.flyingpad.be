using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Common;
using MB.Domain.Entities;

namespace MB.Application.Interfaces.Persistence;

public interface ILinkRepository : IBaseRepository<Link>
{
    Task<List<Link>> GetLinksListByCategory(int? linkCategoryId);
    Task<List<Link>> GetLinksContainingAbc(string? abc);
    Task<PaginationCursor<Link>> GetPageLinksContainingAbc(string abc, Guid startId, int pageSize, bool isFirstItem);
    System.Threading.Tasks.Task UpdateCategories(int linkId, ICollection<int> categoryIds);
}