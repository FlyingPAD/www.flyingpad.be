using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Common;
using MB.Domain.Entities;

namespace MB.Application.Contracts.Persistence
{
    public interface IArtistRepository : IBaseRepository<Artist>
    {
        Task<List<Artist>> GetArtistsByMood( int? moodId );
        Task<List<Artist>> GetArtistsByStyle( int? styleId );
        Task<PaginationCursor<Artist>> GetArtistsPage(int? styleId, int? startId, string abc, int pageSize);
        Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> artistIds);
    }
}