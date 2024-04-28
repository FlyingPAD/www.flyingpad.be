using MB.Application.Features.Tags.Queries.GetTagsFullListQuery;

namespace MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood
{
    public class GetTagsCheckBoxesListDto
    {
        public TagCategoryDto Category { get; set; } = new TagCategoryDto();
        public List<GetTagsCheckBoxesDto> TagsCheckBoxes { get; set; } = [];
    }
}
