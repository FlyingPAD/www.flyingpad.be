namespace MB.Domain.Entities;

public class RelationFranchiseModel
{
    public int FranchiseId { get; set; } = 0;
    public int ModelId { get; set; } = 0;

    // Navigation Properties
    public Franchise? Franchise { get; set; }
    public Model? Model { get; set; }
}
