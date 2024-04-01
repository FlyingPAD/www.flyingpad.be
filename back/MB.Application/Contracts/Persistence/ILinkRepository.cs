using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Common;
using MB.Domain.Entities;

namespace MB.Application.Contracts.Persistence
{
    public interface ILinkRepository : IBaseRepository<Link>
    {
        Task<List<Link>> GetLinksListByCategory(int? linkCategoryId);
        Task<List<Link>> GetLinksContainingAbc(string? abc);
        Task<PaginationCursor<Link>> GetPageLinksContainingAbc(string abc, Guid startId, int pageSize, bool isFirstItem);
    }
}
