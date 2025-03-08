using MB.Domain.FranchiseAggregate;

namespace MB.Domain.ModelAggregate;

public class RelationFranchiseModel
{
    public int FranchiseId { get; set; } = 0;
    public int ModelId { get; set; } = 0;

    public Franchise? Franchise { get; set; }
    public Model? Model { get; set; }
}
