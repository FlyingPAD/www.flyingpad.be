using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Definitions;
using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesCheckBoxesByModel
{
    public class GetFranchisesCheckBoxesByModelQueryHandler(IMapper mapper, IFranchiseRepository franchiseRepository, IModelRepository modelRepository) : IRequestHandler<GetFranchisesCheckBoxesByModelQuery, GetFranchisesCheckBoxesByModelQueryResponse>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IModelRepository _modelRepository = modelRepository;
        private readonly IFranchiseRepository _franchiseRepository = franchiseRepository;

        public async Task<GetFranchisesCheckBoxesByModelQueryResponse> Handle(GetFranchisesCheckBoxesByModelQuery request, CancellationToken cancellationToken)
        {
            int modelId = await _modelRepository.GetEntityIdByBusinessIdAsync(request.ModelId, cancellationToken)
                ?? throw new NotFoundException("Model not found.");

            var franchises = await _franchiseRepository.GetCheckBoxesByModel(modelId);

            return new GetFranchisesCheckBoxesByModelQueryResponse
            {
                Success = true,
                Message = "Model checkboxes loaded.",
                Franchises = _mapper.Map <List<GetFranchisesCheckBoxesByModelQueryDto>> (franchises)
            };
        }
    }
}