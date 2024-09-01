namespace MB.Domain.Entities;

public class RelationLinkCategory
{
    public int LinkId { get; set; }
    public int LinkCategoryId { get; set; }

    public Link? Link { get; set; }
    public LinkCategory? LinkCategory { get; set; }
}