using MB.Application.Interfaces.Persistence;
using MB.Domain.AchievementAggregate;

namespace MB.Persistence.Repositories.Definitions;

public class UserAchievementRepository(Context context) : BaseRepository<UserAchievement>(context), IUserAchievementRepository
{

}