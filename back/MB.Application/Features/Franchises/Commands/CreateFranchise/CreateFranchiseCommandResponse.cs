using MB.Application.Models;

namespace MB.Application.Features.Franchises.Commands.CreateFranchise;

public class CreateFranchiseCommandResponse : BaseResponse
{
    public Guid FranchiseId { get; set; }
}
