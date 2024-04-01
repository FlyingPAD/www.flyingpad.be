using MB.Application.Responses;

namespace MB.Application.Features.Models.Queries.GetModelsByMood
{
    public class GetModelsByMoodQueryResponse : BaseResponse
    {
        public List<GetModelsByMoodQueryVm> ModelsByMood { get; set; } = [];
    }
}
