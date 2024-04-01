using AutoMapper;
using MB.Application.Contracts.Persistence;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Models.Queries.GetModelsByFranchise
{
    public class GetModelsByFranchiseQueryHandler(IMapper mapper, IBaseRepository<Franchise> franchiseRepo, IModelRepository modelRepo ) : IRequestHandler<GetModelsByFranchiseQuery, GetModelsByFranchiseQueryResponse>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IBaseRepository<Franchise> _franchiseRepo = franchiseRepo;
        private readonly IModelRepository _modelRepo = modelRepo;

        public async Task<GetModelsByFranchiseQueryResponse> Handle(GetModelsByFranchiseQuery request, CancellationToken cancellationToken)
        {
            int? franchiseId = await _franchiseRepo.GetPrimaryIdByBusinessIdAsync(request.FranchiseId);

            var models = await _modelRepo.GetModelsByFranchise(franchiseId);

            var response = new GetModelsByFranchiseQueryResponse
            {
                Success = true,
                Message = "Models By Franchise",
                ModelsByFranchise = _mapper.Map<List<GetModelsByFranchiseQueryVm>>(models)
            };

            return response;
        }
    }
}