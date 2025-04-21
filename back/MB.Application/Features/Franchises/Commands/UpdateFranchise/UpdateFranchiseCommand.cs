using MediatR;

namespace MB.Application.Features.Franchises.Commands.UpdateFranchise;

public class UpdateFranchiseCommand : IRequest<BaseResponse>
{
    public Guid FranchiseId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<Guid> MediaIds { get; set; } = [];
}