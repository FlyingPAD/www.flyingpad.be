namespace MB.Application.Features.Tags.Queries.GetTagsList;

public class GetTagsListQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}