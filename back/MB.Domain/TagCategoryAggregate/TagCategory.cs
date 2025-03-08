using MB.Domain.TagAggregate;

namespace MB.Domain.TagCategoryAggregate;

public class TagCategory : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<Tag> Tags { get; set; } = [];
}