using MB.Domain.UserAggregate;

namespace MB.Domain.AchievementAggregate;

public class UserAchievement : AuditableEntity
{
    public int UserId { get; private set; }
    public User User { get; private set; } = null!;
    public int AchievementDefinitionId { get; private set; }
    public AchievementDefinition Definition { get; private set; } = null!;
    public DateTime UnlockedAt { get; private set; }

    private UserAchievement() { }
    public static UserAchievement Unlock(int userId, AchievementDefinition def)
    {
        return new UserAchievement
        {
            UserId = userId,
            AchievementDefinitionId = def.EntityId,
            UnlockedAt = DateTime.UtcNow,
        };
    }
}