using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MB.Domain.ModelAggregate;
using MediatR;

namespace MB.Application.Features.Models.Queries.GetAllModels;

public class GetModelsListQueryHandler(IBaseRepository<Model> modelRepository, IMapper mapper) : IRequestHandler<GetAllModelsQuery, GetAllModelsQueryResponse>
{
    private readonly IBaseRepository<Model> _modelRepository = modelRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetAllModelsQueryResponse> Handle(GetAllModelsQuery request, CancellationToken cancellationToken)
    {
        var models = await _modelRepository.GetAllAsync(request => request.Pseudonym);

        return new GetAllModelsQueryResponse
        {
            Success = true,
            Message = "All models.",
            Models = _mapper.Map<List<GetAllModelsQueryDto>>(models)
        };
    }
}