namespace MB.Domain;

public class AuditableEntity
{
    public int EntityId { get; set; }
    public Guid BusinessId { get; set; } = Guid.NewGuid();
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = "Administrator";
    public DateTime Modified { get; set; } = DateTime.UtcNow;
    public string ModifiedBy { get; set; } = "Administrator";
}