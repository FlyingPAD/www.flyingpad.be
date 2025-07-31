using MB.Application.Models;

namespace MB.Application.Features.Franchises.Queries.GetAllFranchises;

public class GetAllFranchisesQueryResponse : BaseResponse
{
    public List<GetAllFranchisesQueryDto> Franchises { get; set; } = [];
}