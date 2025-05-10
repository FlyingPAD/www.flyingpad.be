using MB.Application.Models;

namespace MB.Application.Features.Users.Queries.GetAllUsers;

public class GetAllUsersQueryDto
{
    public Guid BusinessId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Experience { get; set; }
    // Exemple : nombre d’achievements débloqués
    public int UnlockedCount { get; set; }

    // Ou, si vous voulez la liste complète :
    public List<AchievementDto> Achievements { get; set; } = new();

    public int Level { get; set; }
}