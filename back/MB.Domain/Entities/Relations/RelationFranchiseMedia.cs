namespace MB.Domain.Entities
{
    public class RelationFranchiseMedia
    {
        public int FranchiseId { get; set; } = 0;
        public int MediaId { get; set; } = 0;

        // Navigation Properties :

        public Franchise? Franchise { get; set; }
        public Media? Media { get; set; }
    }
}
