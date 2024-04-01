using MB.Application.Features.Moods.Queries.GetRandomMoodQuery;
using MB.Application.Responses;

namespace MB.Application.Features.Moods.Queries
{
    public class GetRandomMoodQueryResponse : BaseResponse
    {
        public GetRandomMoodQueryVm? Mood { get; set; }
    }
}