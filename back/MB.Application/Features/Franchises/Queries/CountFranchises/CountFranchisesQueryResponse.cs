using MB.Application.Models;

namespace MB.Application.Features.Franchises.Queries.CountFranchises;

public class CountFranchisesQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public int FranchisesCount { get; set; }

    public CountFranchisesQueryResponse() : base ()
    {

    }
}
