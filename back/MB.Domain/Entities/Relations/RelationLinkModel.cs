namespace MB.Domain.Entities;

public class RelationLinkModel
{
    public int LinkId { get; set; }
    public int ModelId { get; set; }

    public Link? Link { get; set; }
    public Model? Model { get; set; }
}