namespace MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood;

public class TagsCheckBoxesDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsChecked { get; set; }
}