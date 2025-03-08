using MB.Domain.LinkCategoryAggregate;

namespace MB.Domain.LinkAggregate;

public class RelationLinkCategory
{
    public int LinkId { get; set; }
    public int LinkCategoryId { get; set; }

    public Link? Link { get; set; }
    public LinkCategory? LinkCategory { get; set; }
}