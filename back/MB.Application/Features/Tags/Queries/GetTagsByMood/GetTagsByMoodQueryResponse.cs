using MB.Application.Models;

namespace MB.Application.Features.Tags.Queries.GetTagsByMood;

public class GetTagsByMoodQueryResponse : BaseResponse
{
    public List<GetTagsByMoodQueryDto> TagsByMood { get; set; } = [];
}