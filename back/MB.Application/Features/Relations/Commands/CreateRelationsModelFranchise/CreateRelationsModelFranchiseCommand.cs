using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsModelFranchise;

public class CreateRelationsModelFranchiseCommand : IRequest<BaseResponse>
{
    public Guid ModelId { get; set; }
    public List<Guid> FranchiseIds { get; set; } = [];
}
