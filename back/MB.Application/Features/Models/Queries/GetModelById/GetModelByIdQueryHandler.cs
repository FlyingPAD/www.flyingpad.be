using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.ModelAggregate;
using MediatR;

namespace MB.Application.Features.Models.Queries.GetModelById;

public class GetModelByIdQueryHandler(IMapper mapper, IBaseRepository<Model> modelRepository) : IRequestHandler<GetModelByIdQuery, GetModelByIdQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Model> _modelRepository = modelRepository;

    public async Task<GetModelByIdQueryResponse> Handle(GetModelByIdQuery request, CancellationToken cancellationToken)
    {
        var model = await _modelRepository.GetByBusinessIdAsync(request.ModelId) 
            ?? throw new NotFoundException("Model not found.");

        return new GetModelByIdQueryResponse
        {
            Success = true,
            Message = $"{model.Pseudonym}.",
            Model = _mapper.Map<GetModelByIdQueryDto>(model)
        };
    }
}