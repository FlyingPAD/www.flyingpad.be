using MB.Application.Models;

namespace MB.Application.Features.Users.Queries.GetUserById;

public class GetUserByIdQueryDto
{
    // Identité
    public Guid BusinessId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public bool IsEmailVerified { get; set; }

    // Profil
    public DateTime Birthdate { get; set; }
    public int Role { get; set; }

    // Gamification
    public int Level { get; set; }
    public int Experience { get; set; }
    public int SeasonScore { get; set; }

    /// <summary>La saison en cours (ou null si aucune).</summary>
    public SeasonDto? Season { get; set; }

    /// <summary>La ligue actuelle de l’utilisateur.</summary>
    public LeagueDto? League { get; set; }

    /// <summary>Les succès débloqués.</summary>
    public List<AchievementDto> Achievements { get; set; } = new();

    // Auditing
    public DateTime Created { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime Modified { get; set; }
    public string? ModifiedBy { get; set; }
}