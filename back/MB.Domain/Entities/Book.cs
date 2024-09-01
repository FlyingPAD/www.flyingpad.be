using MB.Domain.Common;

namespace MB.Domain.Entities;

public class Book : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<RelationBookFranchise>? BookFranchise { get; set; }
    public ICollection<RelationBookModel>? BookModel { get; set; }
}