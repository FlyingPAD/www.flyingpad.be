namespace MB.Application.Models;

/// <summary>
/// DTO représentant un achievement pour l'API.
/// </summary>
public class AchievementDto
{
    /// <summary>Identifiant métier (BusinessId) de l'achievement.</summary>
    public Guid BusinessId { get; set; }

    /// <summary>Titre de l'achievement.</summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>Objectif à atteindre.</summary>
    public string Goal { get; set; } = string.Empty;

    /// <summary>Message affiché lorsque déverrouillé.</summary>
    public string DoneMessage { get; set; } = string.Empty;

    /// <summary>Catégorie (ex : note-master, league, level…).</summary>
    public string Category { get; set; } = string.Empty;

    /// <summary>XP que rapporte l'achievement.</summary>
    public int XpReward { get; set; }

    /// <summary>Date de déverrouillage (null si pas encore).</summary>
    public DateTime? UnlockedAt { get; set; }
}