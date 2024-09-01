using MB.Application.Models;

namespace MB.Application.Features.Moods.Queries.GetMoodsByTag;

public class GetMoodsByTagQueryResponse : BaseResponse
{
    public List<GetMoodsByTagQueryVm> Moods { get; set; } = [];
}