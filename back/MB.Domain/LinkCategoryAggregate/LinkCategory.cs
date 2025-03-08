using MB.Domain.LinkAggregate;

namespace MB.Domain.LinkCategoryAggregate;

public class LinkCategory : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<RelationLinkCategory>? RLinkCategories { get; set; }
}