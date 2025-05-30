using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Definitions;
using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByModel;

public class GetFranchisesByModelQueryHandler(IMapper mapper, IFranchiseRepository franchiseRepo, IModelRepository modelRepo) : IRequestHandler<GetFranchisesByModelQuery, GetFranchisesByModelQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IFranchiseRepository _franchiseRepository = franchiseRepo;
    private readonly IModelRepository _modelRepository = modelRepo;

    public async Task<GetFranchisesByModelQueryResponse> Handle(GetFranchisesByModelQuery request, CancellationToken cancellationToken)
    {
        var modelId = await _modelRepository.GetEntityIdByBusinessIdAsync(request.ModelId, cancellationToken)
            ?? throw new NotFoundException("Model not found.");

        var franchises = await _franchiseRepository.GetFranchisesByModels([modelId]);

        return new GetFranchisesByModelQueryResponse
        {
            Success = true,
            Message = "Franchises by model.",
            FranchisesByModel = _mapper.Map<List<GetFranchisesByModelQueryDto>>(franchises)
        };
    }
}