namespace MB.Domain.BoardAggregate;

public class Board : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Guid UserId { get; set; }
}