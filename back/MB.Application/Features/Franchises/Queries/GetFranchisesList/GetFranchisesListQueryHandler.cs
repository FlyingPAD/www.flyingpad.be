using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesList
{
    public class GetFranchisesListQueryHandler : IRequestHandler<GetFranchisesListQuery, GetFranchisesListQueryResponse>
    {
        private readonly IBaseRepository<Franchise> _franchiseRepository;
        private readonly IMapper _mapper;

        public GetFranchisesListQueryHandler(IBaseRepository<Franchise> franchiseRepository, IMapper mapper)
        {
            _franchiseRepository = franchiseRepository;
            _mapper = mapper;
        }

        public async Task<GetFranchisesListQueryResponse> Handle(GetFranchisesListQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var franchises = await _franchiseRepository.GetAllAsync();
                var response = new GetFranchisesListQueryResponse
                {
                    Success = true,
                    Message = "Here are the Franchises !",
                    FranchisesList = _mapper.Map<List<FranchiseListVm>>(franchises)
                };

                return response;
            }
            catch (Exception ex)
            {
                // Gérez l'exception et renvoyez une réponse d'erreur
                var response = new GetFranchisesListQueryResponse
                {
                    Success = false,
                    ValidationErrors = new List<string> { $"Une erreur s'est produite ( {ex} )." }
                };

                return response;
            }
        }
    }
}
