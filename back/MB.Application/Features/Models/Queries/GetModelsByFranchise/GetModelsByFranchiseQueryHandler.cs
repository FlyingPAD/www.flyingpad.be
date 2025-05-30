using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Interfaces.Persistence.Definitions;
using MB.Domain.FranchiseAggregate;
using MediatR;

namespace MB.Application.Features.Models.Queries.GetModelsByFranchise;

public class GetModelsByFranchiseQueryHandler(IMapper mapper, IBaseRepository<Franchise> franchiseRepo, IModelRepository modelRepo ) : IRequestHandler<GetModelsByFranchiseQuery, GetModelsByFranchiseQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Franchise> _franchiseRepo = franchiseRepo;
    private readonly IModelRepository _modelRepo = modelRepo;

    public async Task<GetModelsByFranchiseQueryResponse> Handle(GetModelsByFranchiseQuery request, CancellationToken cancellationToken)
    {
        int franchiseId = await _franchiseRepo.GetEntityIdByBusinessIdAsync(request.FranchiseId, cancellationToken)
            ?? throw new NotFoundException("Franchise not found.");

        var models = await _modelRepo.GetModelsByFranchise(franchiseId);

        return new GetModelsByFranchiseQueryResponse
        {
            Success = true,
            Message = "Models by franchise.",
            ModelsByFranchise = _mapper.Map<List<GetModelsByFranchiseQueryDto>>(models)
        };
    }
}