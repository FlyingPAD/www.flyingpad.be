using MB.Domain.Common;

namespace MB.Domain.Entities
{
    public class RelationLinkModel
    {
        public int LinkId { get; set; } = 0;
        public int ModelId { get; set; } = 0;

        // Navigation Properties :

        public Link? Link { get; set; }
        public Model? Model { get; set; }
    }
}