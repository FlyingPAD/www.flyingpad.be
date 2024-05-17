using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;

namespace MB.Persistence.Repositories;

public class VideoYouTubeRepository(Context context) : BaseRepository<VideoYouTube>(context)
{

}