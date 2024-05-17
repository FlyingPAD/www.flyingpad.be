using MB.Application.Responses;

namespace MB.Application.Features.Franchises.Commands.DeleteFranchise;

public class DeleteFranchiseCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public DeleteFranchiseDto DeletedFranchiseId { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public DeleteFranchiseCommandResponse() : base()
    {

    }
}
