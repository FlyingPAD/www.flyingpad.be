using MB.Domain.SeasonAggregate;

namespace MB.Domain.LeagueAggregate;

public class LeagueDefinition : AuditableEntity
{
    public string Name { get; private set; } = string.Empty;
    public int MinExperience { get; private set; }
    public int? MaxExperience { get; private set; }
    public int Order { get; private set; }
    public string? IconCssClass { get; private set; }
    public int? SeasonId { get; private set; }
    public Season? Season { get; private set; }

    private LeagueDefinition() { }

    public LeagueDefinition(
        string name,
        int minExp,
        int? maxExp,
        int order,
        string? iconCss = null)
    {
        Name = name;
        MinExperience = minExp;
        MaxExperience = maxExp;
        Order = order;
        IconCssClass = iconCss;
    }
}