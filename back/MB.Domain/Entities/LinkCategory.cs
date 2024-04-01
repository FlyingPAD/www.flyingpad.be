using MB.Domain.Common;

namespace MB.Domain.Entities
{
    public class LinkCategory : AuditableEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Navigation Properties :

        public ICollection<RelationLinkCategory>? LinkCategories { get; set; }
    }
}