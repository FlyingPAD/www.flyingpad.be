namespace MB.Application.Features.Tags.Queries.GetTagsFullListQuery;

public class TagDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}