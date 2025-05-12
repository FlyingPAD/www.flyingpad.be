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
}