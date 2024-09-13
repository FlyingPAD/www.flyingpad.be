using MB.Application.Models;

namespace MB.Application.Features.Tags.Queries.GetTagsFullListQuery;

public class GetTagsFullListQueryResponse : BaseResponse
{
    public List<GetTagsFullListQueryDto> CategoriesWithTags { get; set; } = [];
}
