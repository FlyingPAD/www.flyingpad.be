using MB.Domain;
using MB.Domain.LinkAggregate;

namespace MB.Application.Interfaces.Persistence.Definitions;

public interface ILinkRepository : IBaseRepository<Link>
{
    Task<List<Link>> GetLinksListByCategory(int? linkCategoryId);
    Task<List<Link>> GetLinksContainingAbc(string? abc);
    Task<PaginationCursor<Link>> GetPageLinksContainingAbc(string abc, Guid startId, int pageSize, bool isFirstItem);
    Task AddLinkCategoriesAsync(int linkId, IEnumerable<int> categoryIds);
    Task RemoveLinkCategoriesAsync(Link link);
    Task<Link?> GetLinkWithCategoriesAsync(int linkId);
    Task<IEnumerable<Link>> GetLinksByArtist(int artistId);
    Task<IEnumerable<Link>> GetLinksByModel(int modelId);
}