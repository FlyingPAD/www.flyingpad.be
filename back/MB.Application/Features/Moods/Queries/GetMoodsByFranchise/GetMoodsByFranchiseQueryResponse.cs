using MB.Application.Responses;

namespace MB.Application.Features.Moods.Queries.GetMoodsByFranchise
{
    public class GetMoodsByFranchiseQueryResponse : BaseResponse
    {
        public List<GetMoodsByFranchiseQueryVm> Moods { get; set; } = [];
    }
}
