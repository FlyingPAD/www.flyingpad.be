using MB.Domain.Common;

namespace MB.Domain.Entities;

public class TagCategory : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<Tag> Tags { get; set; } = [];
}