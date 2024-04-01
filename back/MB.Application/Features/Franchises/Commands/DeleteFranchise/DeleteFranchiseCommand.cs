using MediatR;

namespace MB.Application.Features.Franchises.Commands.DeleteFranchise
{
    public class DeleteFranchiseCommand : IRequest<DeleteFranchiseCommandResponse>
    {
        public Guid FranchiseId { get; set; }
    }
}
