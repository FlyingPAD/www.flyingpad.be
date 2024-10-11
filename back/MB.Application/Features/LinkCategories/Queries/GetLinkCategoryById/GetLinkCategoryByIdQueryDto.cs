namespace MB.Application.Features.LinkCategories.Queries.GetLinkCategoryById;

public class GetLinkCategoryByIdQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Created { get; set; }
    public string? CreatedBy { get; set; } = string.Empty;
    public DateTime Modified { get; set; }
    public string? ModifiedBy { get; set; } = string.Empty;
}