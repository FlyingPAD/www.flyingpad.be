namespace MB.Domain.Entities
{
    public class RelationBookFranchise
    {
        public int BookId { get; set; } = 0;
        public int FranchiseId { get; set; } = 0;

        // Navigation Properties :

        public Book? Book { get; set; }
        public Franchise? Franchise { get; set; }
    }
}
