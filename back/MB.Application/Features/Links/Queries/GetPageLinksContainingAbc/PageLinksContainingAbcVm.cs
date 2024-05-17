namespace MB.Application.Features.Links.Queries.GetPageLinksContainingAbc;

public class PageLinksContainingAbcVm
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Url { get; set; } = string.Empty;
}
