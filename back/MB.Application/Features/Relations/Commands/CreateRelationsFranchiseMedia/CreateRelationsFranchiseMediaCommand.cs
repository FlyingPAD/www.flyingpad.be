using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsFranchiseMedia;

public class CreateRelationsFranchiseMediaCommand : IRequest<BaseResponse>
{
    public Guid FranchiseId { get; set; }
    public List<Guid> MediaIds { get; set; } = [];
}