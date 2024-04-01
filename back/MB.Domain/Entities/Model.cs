using MB.Domain.Common;

namespace MB.Domain.Entities
{
    public class Model : AuditableEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Pseudonym { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;


        // Navigation Properties :

        public ICollection<RelationMoodModel>? MoodModels { get; set; }
        public ICollection<RelationFranchiseModel>? FranchiseModels { get; set; }
        public ICollection<RelationLinkModel>? LinkModels { get; set; }
    }
}