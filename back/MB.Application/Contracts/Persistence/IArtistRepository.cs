using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Artists.Queries.GetArtistCheckBoxesByMood;
using MB.Domain.Common;
using MB.Domain.Entities;

namespace MB.Application.Contracts.Persistence
{
    public interface IArtistRepository : IBaseRepository<Artist>
    {
        Task<IEnumerable<Artist>> GetArtistsByMood( int? moodId );
        Task<IEnumerable<Artist>> GetArtistsByStyle( int? styleId );
        Task<PaginationCursor<Artist>> GetArtistsPage(int? styleId, int? startId, string abc, int pageSize);
        Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> artistIds);
        Task<IEnumerable<GetArtistCheckBoxesByMoodQueryDto>> GetArtistsCheckBoxesByMood(int moodId);
        System.Threading.Tasks.Task DeleteStyles(int artistId);
    }
}