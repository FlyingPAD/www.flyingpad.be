using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Franchises.Commands.UpdateFranchise;

public class UpdateFranchiseCommand : IRequest<BaseResponse>
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}