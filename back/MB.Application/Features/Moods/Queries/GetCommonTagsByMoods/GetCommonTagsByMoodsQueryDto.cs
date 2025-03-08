using MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood;
using MB.Application.Features.Tags.Queries.GetTagsFullListQuery;

namespace MB.Application.Features.Moods.Queries.GetCommonTagsByMoods;

public class GetCommonTagsByMoodsQueryDto
{
    public TagCategoryDto Category { get; set; } = new();
    public List<TagsCheckBoxesDto> TagsCheckBoxes { get; set; } = [];
}