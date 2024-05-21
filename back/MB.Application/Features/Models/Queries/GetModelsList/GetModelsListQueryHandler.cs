using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Models.Queries.GetModelsList;

public class GetModelsListQueryHandler(IBaseRepository<Model> modelRepository, IMapper mapper) : IRequestHandler<GetModelsListQuery, GetModelsListQueryResponse>
{
    private readonly IBaseRepository<Model> _modelRepository = modelRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetModelsListQueryResponse> Handle(GetModelsListQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var models = await _modelRepository.GetAllAsync();
            var response = new GetModelsListQueryResponse
            {
                Success = true,
                Message = "Models Retrieved Successfully",
                Models = _mapper.Map<List<ModelListVm>>(models)
            };

            return response;
        }
        catch (Exception ex)
        {
            // Gérez l'exception et renvoyez une réponse d'erreur
            var response = new GetModelsListQueryResponse
            {
                Success = false,
                ValidationErrors = [ "Une erreur s'est produite ( {ex} )."]
            };

            return response;
        }
    }
}
