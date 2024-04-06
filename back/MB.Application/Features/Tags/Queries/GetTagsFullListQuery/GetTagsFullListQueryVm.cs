namespace MB.Application.Features.Tags.Queries.GetTagsFullListQuery
{
    public class GetTagsFullListQueryVm
    {
        public TagCategoryDto Category { get; set; } = new TagCategoryDto();
        public List<TagDto> Tags { get; set; } = [];
    }
}