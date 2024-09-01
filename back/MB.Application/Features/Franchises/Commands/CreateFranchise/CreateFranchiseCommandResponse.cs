using MB.Application.Models;

namespace MB.Application.Features.Franchises.Commands.CreateFranchise;

public class CreateFranchiseCommandResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public CreateFranchiseDto Franchise { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public CreateFranchiseCommandResponse() : base()
    {

    }
}
