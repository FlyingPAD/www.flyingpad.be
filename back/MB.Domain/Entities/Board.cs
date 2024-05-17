using MB.Domain.Common;

namespace MB.Domain.Entities;

public class Board : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Guid UserId { get; set; } = Guid.Empty;
}