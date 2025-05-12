namespace MB.Application.Models;

public class AchievementDto
{
    public string Code { get; set; } = string.Empty;
    public Guid BusinessId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Goal { get; set; } = string.Empty;
    public string DoneMessage { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public int XpReward { get; set; }
    public DateTime? UnlockedAt { get; set; }
}