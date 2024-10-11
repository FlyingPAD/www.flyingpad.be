using MB.Application.Models;

namespace MB.Application.Features.Tags.Queries.GetAllTags;

public class GetAllTagsQueryResponse : BaseResponse
{
    public List<GetAllTagsQueryDto> Tags { get; set; } = [];
}