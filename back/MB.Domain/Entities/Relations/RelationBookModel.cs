namespace MB.Domain.Entities
{
    public class RelationBookModel
    {
        public int BookId { get; set; } = 0;
        public int ModelId { get; set; } = 0;

        // Navigation Properties :

        public Book? Book { get; set; }
        public Model? Model { get; set; }
    }
}