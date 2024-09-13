namespace MB.Application.Features.Tags.Queries.GetTagsFullListQuery;

public class GetTagsFullListQueryDto
{
    public TagCategoryDto Category { get; set; } = new();
    public List<TagDto> Tags { get; set; } = [];
}