using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesList
{
    public class GetAllFranchisesQueryHandler(IBaseRepository<Franchise> franchiseRepository, IMapper mapper) : IRequestHandler<GetAllFranchisesQuery, GetAllFranchisesQueryResponse>
    {
        private readonly IBaseRepository<Franchise> _franchiseRepository = franchiseRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<GetAllFranchisesQueryResponse> Handle(GetAllFranchisesQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var franchises = await _franchiseRepository.GetAllAsync();
                var response = new GetAllFranchisesQueryResponse
                {
                    Success = true,
                    Message = "Here are the Franchises !",
                    FranchisesList = _mapper.Map<List<GetAllFranchisesQueryVm>>(franchises)
                };

                return response;
            }
            catch (Exception ex)
            {
                // Gérez l'exception et renvoyez une réponse d'erreur
                var response = new GetAllFranchisesQueryResponse
                {
                    Success = false,
                    ValidationErrors = [$"Error : ( {ex} )."]
                };

                return response;
            }
        }
    }
}
