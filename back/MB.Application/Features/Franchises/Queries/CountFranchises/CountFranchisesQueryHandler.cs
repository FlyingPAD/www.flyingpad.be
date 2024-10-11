using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Franchises.Queries.CountFranchises;

public class CountFranchisesQueryHandler(IBaseRepository<Franchise> franchiseRepository) : IRequestHandler<CountFranchisesQuery, CountFranchisesQueryResponse>
{
    private readonly IBaseRepository<Franchise> _franchiseRepository = franchiseRepository;

    public async Task<CountFranchisesQueryResponse> Handle(CountFranchisesQuery request, CancellationToken cancellationToken)
    {
        return new CountFranchisesQueryResponse
        {
            Success = true,
            Message = "Franchises count completed.",
            TotalFranchises = await _franchiseRepository.CountAsync()
        };
    }
}