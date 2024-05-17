using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;

namespace MB.Persistence.Repositories;

public class VideoRepository(Context context) : BaseRepository<Video>(context)
{

}