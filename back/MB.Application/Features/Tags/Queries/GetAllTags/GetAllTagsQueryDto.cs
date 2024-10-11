namespace MB.Application.Features.Tags.Queries.GetAllTags;

public class GetAllTagsQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}