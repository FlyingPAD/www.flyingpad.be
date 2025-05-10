using MB.Domain.LeagueAggregate;
using MB.Domain.UserAggregate;

namespace MB.Domain.SeasonAggregate;

public class Season : AuditableEntity
{
    public string Name { get; private set; } = string.Empty;
    public DateTime StartsAt { get; private set; }
    public DateTime EndsAt { get; private set; }

    private Season() { }

    public Season(string name, DateTime startsAt, DateTime endsAt)
    {
        Name = name;
        StartsAt = startsAt;
        EndsAt = endsAt;
    }

    public bool IsActive => DateTime.UtcNow >= StartsAt && DateTime.UtcNow <= EndsAt;

    // Méthode pour clôture et promotion/démotion
    public void CloseSeason(IEnumerable<User> users, IEnumerable<LeagueDefinition> leagues)
    {
        // Implémenter la logique de promotion/démotion
    }
}