using MB.Application.Responses;

namespace MB.Application.Features.Models.Queries.GetModelsByFranchise;

public class GetModelsByFranchiseQueryResponse : BaseResponse
{
    public List<GetModelsByFranchiseQueryVm> ModelsByFranchise { get; set; } = [];
}