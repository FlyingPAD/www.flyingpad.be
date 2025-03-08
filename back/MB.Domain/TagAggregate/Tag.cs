using MB.Domain.MoodAggregate;
using MB.Domain.TagCategoryAggregate;

namespace MB.Domain.TagAggregate;

public class Tag : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int TagCategoryId { get; set; } = 0;

    public TagCategory? TagCategory { get; set; }
    public ICollection<RelationMoodTag>? MoodTags { get; set; }
}