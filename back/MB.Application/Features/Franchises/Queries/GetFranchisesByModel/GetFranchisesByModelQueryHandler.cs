using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByModel;

public class GetFranchisesByModelQueryHandler(IMapper mapper, IFranchiseRepository franchiseRepo, IModelRepository modelRepo) : IRequestHandler<GetFranchisesByModelQuery, GetFranchisesByModelQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IFranchiseRepository _franchiseRepository = franchiseRepo;
    private readonly IModelRepository _modelRepository = modelRepo;

    public async Task<GetFranchisesByModelQueryResponse> Handle(GetFranchisesByModelQuery request, CancellationToken cancellationToken)
    {
        var modelEntityId = await _modelRepository.GetPrimaryIdByBusinessIdAsync(request.ModelId);

        if (!modelEntityId.HasValue)
        {
            return new GetFranchisesByModelQueryResponse
            {
                Success = false,
                Message = "Franchise was not found."
            };
        }

        var franchises = await _franchiseRepository.GetFranchisesByModels(new List<int> { modelEntityId.Value });

        var response = new GetFranchisesByModelQueryResponse
        {
            Success = true,
            Message = "Franchises retrieved successfully",
            FranchisesByModel = _mapper.Map<List<GetFranchisesByModelQueryVm>>(franchises)
        };

        return response;
    }
}