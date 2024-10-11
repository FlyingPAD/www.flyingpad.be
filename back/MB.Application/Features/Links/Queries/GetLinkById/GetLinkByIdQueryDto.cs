namespace MB.Application.Features.Links.Queries.GetLinkById;

public class GetLinkByIdQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public DateTime Created { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime Modified { get; set; }
    public string ModifiedBy { get; set; } = string.Empty;
}