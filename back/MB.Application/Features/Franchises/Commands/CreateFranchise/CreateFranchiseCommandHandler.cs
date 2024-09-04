using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Franchises.Commands.CreateFranchise;

public class CreateFranchiseCommandHandler(IBaseRepository<Franchise> franchiseRepository) : IRequestHandler<CreateFranchiseCommand, CreateFranchiseCommandResponse>
{
    private readonly IBaseRepository<Franchise> _franchiseRepository = franchiseRepository;

    public async Task<CreateFranchiseCommandResponse> Handle(CreateFranchiseCommand request, CancellationToken cancellationToken)
    {
        var franchise = new Franchise
        {
            Name = request.Name,
            Description = request.Description
        };

        franchise = await _franchiseRepository.CreateAsync(franchise);

        return new CreateFranchiseCommandResponse
        {
            Success = true,
            Message = "Success.",
            FranchiseId = franchise.BusinessId
        };
    }
}