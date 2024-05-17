namespace MB.Domain.Entities;

public class RelationBookModel
{
    public int BookId { get; set; }
    public int ModelId { get; set; }

    // Navigation Properties
    public Book? Book { get; set; }
    public Model? Model { get; set; }
}