using MB.Domain.ArtistAggregate;
using MB.Domain.MoodAggregate;

namespace MB.Domain.ModelAggregate;

public class Model : AuditableEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Pseudonym { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<RelationMoodModel>? MoodModels { get; set; }
    public ICollection<RelationFranchiseModel>? FranchiseModels { get; set; }
    public ICollection<RelationLinkModel>? LinkModels { get; set; }
    public ICollection<RelationBookModel>? BookModel { get; set; }
}