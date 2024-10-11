using MB.Application.Models;

namespace MB.Application.Features.Franchises.Queries.CountFranchises;

public class CountFranchisesQueryResponse : BaseResponse
{
    public int TotalFranchises { get; set; }
}