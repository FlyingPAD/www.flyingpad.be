using MB.Domain.Common;

namespace MB.Domain.Entities;

public class LinkCategory : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<RelationLinkCategory>? RLinkCategories { get; set; }
}