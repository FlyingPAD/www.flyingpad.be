using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Franchises.Commands.DeleteFranchise;

public class DeleteFranchiseCommandHandler(IBaseRepository<Franchise> franchiseRepository) : IRequestHandler<DeleteFranchiseCommand, DeleteFranchiseCommandResponse>
{
    private readonly IBaseRepository<Franchise> _franchiseRepository = franchiseRepository;

    public async Task<DeleteFranchiseCommandResponse> Handle(DeleteFranchiseCommand request, CancellationToken cancellationToken)
    {
        var franchise = await _franchiseRepository.GetByBusinessIdAsync(request.FranchiseId) ?? throw new NotFoundException($"Franchise with ID {request.FranchiseId} was not found.");

        await _franchiseRepository.DeleteAsync(franchise);

        return new DeleteFranchiseCommandResponse
        {
            Success = true,
            Message = "Success."
        };
    }
}