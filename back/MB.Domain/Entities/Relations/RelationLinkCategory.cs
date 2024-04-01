using MB.Domain.Common;

namespace MB.Domain.Entities
{
    public class RelationLinkCategory
    {
        public int LinkId { get; set; } = 0;
        public int LinkCategoryId { get; set; } = 0;

        // Navigation Properties :

        public Link? Link { get; set; }
        public LinkCategory? LinkCategory { get; set; }
    }
}