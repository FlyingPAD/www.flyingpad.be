namespace MB.Domain.Common
{
    public class AuditableEntity
    {
        public int EntityId { get; set; } = 0;
        public Guid BusinessId { get; set; } = Guid.NewGuid();
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime Modified { get; set; } = DateTime.UtcNow;
        public string ModifiedBy { get; set; } = string.Empty;
    }
}