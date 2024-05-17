using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Models.Queries.CountModels;

public class CountModelsQueryHandler : IRequestHandler<CountModelsQuery, CountModelsQueryResponse>
{
    private readonly IBaseRepository<Model> _modelRepository;

    public CountModelsQueryHandler(IBaseRepository<Model> modelRepository)
    {
        _modelRepository = modelRepository;
    }

    public async Task<CountModelsQueryResponse> Handle(CountModelsQuery request, CancellationToken cancellationToken)
    {
        var modelsCount = await _modelRepository.CountAsync();

        return new CountModelsQueryResponse
        {
            Success = true,
            Message = $"Total Models : {modelsCount}",
            ModelsCount = modelsCount
        };
    }
}