using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Franchises.Commands.DeleteFranchise;

public class DeleteFranchiseCommand : IRequest<BaseResponse>
{
    public Guid FranchiseId { get; set; }
}