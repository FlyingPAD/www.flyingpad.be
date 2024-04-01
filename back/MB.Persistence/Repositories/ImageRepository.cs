using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;

namespace MB.Persistence.Repositories
{
    public class ImageRepository : BaseRepository<Image>
    {
        public ImageRepository(Context context) : base(context)
        {

        }
    }
}
