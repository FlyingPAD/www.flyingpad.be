using MB.Application.Features.Tags.Queries.GetTagsFullListQuery;

namespace MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood;

public class GetTagsCheckBoxesByMoodQueryDto
{
    public TagCategoryDto Category { get; set; } = new();
    public List<TagsCheckBoxesDto> TagsCheckBoxes { get; set; } = [];
}