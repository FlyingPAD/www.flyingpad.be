namespace MB.Application.Features.Tags.Queries.GetTagById;

public class GetTagByIdQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Created { get; set; } = DateTime.MinValue;
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime Modified { get; set; } = DateTime.MinValue;
    public string ModifiedBy { get; set; } = string.Empty;
    public Guid TagCategoryId { get; set; }
}