using MB.Application.Contracts.Persistence;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;

namespace MB.Persistence.Repositories
{
    public class MediaRepository : BaseRepository<Media>, IMediaRepository
    {
        public MediaRepository(Context context) : base(context)
        {
             
        }
    }
}
