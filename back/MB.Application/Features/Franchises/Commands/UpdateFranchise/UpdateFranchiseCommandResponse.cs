using MB.Application.Responses;

namespace MB.Application.Features.Franchises.Commands.UpdateFranchise;

public class UpdateFranchiseCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public UpdateFranchiseDto UpdatedFranchise { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public UpdateFranchiseCommandResponse() : base()
    {

    }
}
