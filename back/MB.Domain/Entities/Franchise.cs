using MB.Domain.Common;

namespace MB.Domain.Entities;

public class Franchise : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    // Navigation Properties :

    public ICollection<RelationMoodFranchise>? MoodFranchises { get; set; }
    public ICollection<RelationFranchiseMedia>? FranchiseMedias { get; set; }
    public ICollection<RelationFranchiseModel>? FranchiseModels { get; set; }
    public ICollection<RelationBookFranchise>? BookFranchise { get; set; }
}