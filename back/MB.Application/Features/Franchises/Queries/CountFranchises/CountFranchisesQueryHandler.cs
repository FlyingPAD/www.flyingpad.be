using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Franchises.Queries.CountFranchises
{
    public class CountFranchisesQueryHandler : IRequestHandler<CountFranchisesQuery, CountFranchisesQueryResponse>
    {
        private readonly IBaseRepository<Franchise> _franchiseRepository;

        public CountFranchisesQueryHandler(IBaseRepository<Franchise> franchiseRepository)
        {
            _franchiseRepository = franchiseRepository;
        }

        public async Task<CountFranchisesQueryResponse> Handle(CountFranchisesQuery request, CancellationToken cancellationToken)
        {
            var franchisesCount = await _franchiseRepository.CountAsync();

            return new CountFranchisesQueryResponse
            {
                Success = true,
                Message = $"Total Franchises : {franchisesCount}",
                FranchisesCount = franchisesCount
            };
        }

    }
}
