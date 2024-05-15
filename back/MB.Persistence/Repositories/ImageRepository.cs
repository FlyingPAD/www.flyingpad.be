using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;

namespace MB.Persistence.Repositories
{
    public class ImageRepository(Context context) : BaseRepository<Image>(context)
    {

    }
}
