using MB.Domain.Common;

namespace MB.Domain.Entities;

public class TagCategory : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    // Navigation Properties :

    public ICollection<Tag> Tags { get; set; } = new List<Tag>();
}