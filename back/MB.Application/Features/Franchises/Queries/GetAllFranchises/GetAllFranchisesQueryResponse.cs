using MB.Application.Models;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesList;

public class GetAllFranchisesQueryResponse : BaseResponse
{
    public List<GetAllFranchisesQueryDto> Franchises { get; set; } = [];
}