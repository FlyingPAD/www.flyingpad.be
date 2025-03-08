using MB.Application.Interfaces.Persistence;
using MB.Domain.ModelAggregate;
using MediatR;

namespace MB.Application.Features.Models.Queries.CountModels;

public class CountModelsQueryHandler(IBaseRepository<Model> modelRepository) : IRequestHandler<CountModelsQuery, CountModelsQueryResponse>
{
    private readonly IBaseRepository<Model> _modelRepository = modelRepository;

    public async Task<CountModelsQueryResponse> Handle(CountModelsQuery request, CancellationToken cancellationToken)
    {
        return new CountModelsQueryResponse
        {
            Success = true,
            Message = "Models count completed.",
            TotalModels = await _modelRepository.CountAsync()
        };
    }
}