using MB.Application.Models;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMood;

public class GetFranchisesByMoodQueryResponse : BaseResponse
{
    public List<GetFranchisesByMoodQueryVm> FranchisesByMood { get; set; } = [];
}
