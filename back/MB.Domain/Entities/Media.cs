using MB.Domain.Common;

namespace MB.Domain.Entities;

public class Media : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<RelationFranchiseMedia>? FranchiseMedias { get; set; }
}