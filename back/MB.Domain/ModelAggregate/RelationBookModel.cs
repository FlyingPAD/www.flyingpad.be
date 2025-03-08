using MB.Domain.BookAggregate;

namespace MB.Domain.ModelAggregate;

public class RelationBookModel
{
    public int BookId { get; set; }
    public int ModelId { get; set; }

    public Book? Book { get; set; }
    public Model? Model { get; set; }
}