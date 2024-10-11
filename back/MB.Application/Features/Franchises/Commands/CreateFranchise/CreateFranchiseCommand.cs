using MediatR;

namespace MB.Application.Features.Franchises.Commands.CreateFranchise;

public class CreateFranchiseCommand : IRequest<CreateFranchiseCommandResponse>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<Guid> MediaIds { get; set; } = [];
}