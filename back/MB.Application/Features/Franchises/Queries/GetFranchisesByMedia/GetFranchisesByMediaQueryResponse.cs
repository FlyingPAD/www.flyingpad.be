using MB.Application.Responses;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMedia;

public class GetFranchisesByMediaQueryResponse : BaseResponse
{
    public List<GetFranchisesByMediaQueryVm> Franchises { get; set; } = [];
}
