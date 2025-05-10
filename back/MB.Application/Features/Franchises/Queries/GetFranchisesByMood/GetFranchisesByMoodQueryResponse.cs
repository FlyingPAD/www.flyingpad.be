using MB.Application.Models;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMood;

public class GetFranchisesByMoodQueryResponse : BaseResponse
{
    public List<GetFranchisesByMoodQueryDto> FranchisesByMood { get; set; } = [];
}