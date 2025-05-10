namespace MB.Domain.AchievementAggregate;

public class AchievementDefinition : AuditableEntity
{
    public string Title { get; private set; } = string.Empty;
    public string Goal { get; private set; } = string.Empty;
    public string DoneMessage { get; private set; } = string.Empty;
    public string Category { get; private set; } = string.Empty;
    public int XpReward { get; private set; }
    public string? IconUrl { get; private set; }

    private AchievementDefinition() { }

    public AchievementDefinition(
        string title,
        string goal,
        string doneMessage,
        string category,
        int xpReward,
        string? iconUrl = null)
    {
        Title = title;
        Goal = goal;
        DoneMessage = doneMessage;
        Category = category;
        XpReward = xpReward;
        IconUrl = iconUrl;
    }
}