using MB.Application.Models;

namespace MB.Application.Features.Models.Queries.GetModelCheckBoxesByMood;

public class GetModelCheckBoxesByMoodQueryResponse : BaseResponse
{
    public IEnumerable<GetModelCheckBoxesByMoodQueryDto> Models { get; set; } = [];
}
