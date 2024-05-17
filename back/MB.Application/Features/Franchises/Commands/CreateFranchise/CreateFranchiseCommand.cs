using MediatR;

namespace MB.Application.Features.Franchises.Commands.CreateFranchise;

public class CreateFranchiseCommand : IRequest<CreateFranchiseCommandResponse>
{
    public string Name { get; set; } = string.Empty;
}
