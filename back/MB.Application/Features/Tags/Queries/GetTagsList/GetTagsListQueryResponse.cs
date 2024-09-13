using MB.Application.Models;

namespace MB.Application.Features.Tags.Queries.GetTagsList;

public class GetTagsListQueryResponse : BaseResponse
{
    public List<GetTagsListQueryDto> Tags { get; set; } = [];
}