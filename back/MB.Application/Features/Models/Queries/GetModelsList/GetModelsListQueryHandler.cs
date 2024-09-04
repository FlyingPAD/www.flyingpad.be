using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Models.Queries.GetModelsList;

public class GetModelsListQueryHandler(IBaseRepository<Model> modelRepository, IMapper mapper) : IRequestHandler<GetModelsListQuery, GetModelsListQueryResponse>
{
    private readonly IBaseRepository<Model> _modelRepository = modelRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetModelsListQueryResponse> Handle(GetModelsListQuery request, CancellationToken cancellationToken)
    {
        var models = await _modelRepository.GetAllAsync(x => x.Pseudonym);
        var response = new GetModelsListQueryResponse
        {
            Success = true,
            Message = "Success.",
            Models = _mapper.Map<List<ModelListVm>>(models)
        };

        return response;
    }
}