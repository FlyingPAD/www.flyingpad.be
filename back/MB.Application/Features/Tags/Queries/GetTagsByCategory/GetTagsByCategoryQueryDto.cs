namespace MB.Application.Features.Tags.Queries.GetTagsByCategory;

public class GetTagsByCategoryQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}