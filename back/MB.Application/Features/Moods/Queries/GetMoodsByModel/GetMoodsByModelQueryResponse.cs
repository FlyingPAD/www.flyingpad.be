using MB.Application.Models;

namespace MB.Application.Features.Moods.Queries.GetMoodsByModel;

public class GetMoodsByModelQueryResponse : BaseResponse
{
    public List<GetMoodsByModelQueryVm> Moods { get; set; } = [];
}
