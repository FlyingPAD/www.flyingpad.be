using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;

namespace MB.Persistence.Repositories;

public class UserRepository(Context context) : BaseRepository<User>(context)
{

}