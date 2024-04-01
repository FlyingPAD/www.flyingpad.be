using MB.Domain.Common;

namespace MB.Domain.Entities
{
    public class Tag : AuditableEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int TagCategoryId { get; set; } = 0;

        // Navigation Properties :

        public TagCategory? TagCategory { get; set; }
        public ICollection<RelationMoodTag>? MoodTags { get; set; }
    }
}