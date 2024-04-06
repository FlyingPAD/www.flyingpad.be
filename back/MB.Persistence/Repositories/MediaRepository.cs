using MB.Application.Contracts.Persistence;
using MB.Application.Features.Franchises.Queries.GetFranchisesList;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories
{
    public class MediaRepository(Context context) : BaseRepository<Media>(context), IMediaRepository
    {
        public async Task<IEnumerable<GFLQMediaDto>> GetMediasFullList()
            {
                var mediasFullList = new List<GFLQMediaDto>();

                var medias = await _context.Medias
                    .OrderBy(media => media.Name)
                    .Select(media =>
                    {
                        mediasFullList.medi
                    })
                    .ToListAsync();

                return medias;


            }
    }
}
