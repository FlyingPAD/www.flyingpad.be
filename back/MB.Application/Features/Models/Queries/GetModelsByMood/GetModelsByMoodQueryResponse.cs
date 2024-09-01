using MB.Application.Models;

namespace MB.Application.Features.Models.Queries.GetModelsByMood;

public class GetModelsByMoodQueryResponse : BaseResponse
{
    public List<GetModelsByMoodQueryVm> Models { get; set; } = [];
}
