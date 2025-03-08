using MB.Domain.FranchiseAggregate;

namespace MB.Domain.MediumAggregate;

public class Media : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<RelationFranchiseMedia>? FranchiseMedias { get; set; }
}