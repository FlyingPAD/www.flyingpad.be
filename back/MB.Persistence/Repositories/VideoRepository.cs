using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;

namespace MB.Persistence.Repositories
{
    public class VideoRepository : BaseRepository<Video>
    {
        public VideoRepository(Context context) : base(context)
        {

        }
    }
}