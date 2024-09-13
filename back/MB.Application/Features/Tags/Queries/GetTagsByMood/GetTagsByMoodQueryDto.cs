namespace MB.Application.Features.Tags.Queries.GetTagsByMood;

public class GetTagsByMoodQueryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}