using MB.Application.Responses;

namespace MB.Application.Features.Tags.Queries.GetTagsByMood
{
    public class GetTagsByMoodQueryResponse : BaseResponse
    {
        public List<GetTagsByMoodQueryVm> TagsByMood { get; set; } = new List<GetTagsByMoodQueryVm>();
    }
}
