using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;

namespace MB.Persistence.Repositories
{
    public class VideoYouTubeRepository : BaseRepository<VideoYouTube>
    {
        public VideoYouTubeRepository(Context context) : base(context)
        {

        }
    }
}