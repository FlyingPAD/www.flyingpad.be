namespace MB.Domain.Entities;

public class RelationFranchiseMedia
{
    public int FranchiseId { get; set; }
    public int MediaId { get; set; }

    public Franchise? Franchise { get; set; }
    public Media? Media { get; set; }
}
