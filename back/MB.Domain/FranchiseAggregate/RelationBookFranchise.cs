using MB.Domain.BookAggregate;

namespace MB.Domain.FranchiseAggregate;

public class RelationBookFranchise
{
    public int BookId { get; set; }
    public int FranchiseId { get; set; }

    public Book? Book { get; set; }
    public Franchise? Franchise { get; set; }
}
