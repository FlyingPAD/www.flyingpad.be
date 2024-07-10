using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Models.Queries.GetModelById;

public class GetModelByIdQueryHandler(IMapper mapper, IBaseRepository<Model> modelRepository) : IRequestHandler<GetModelByIdQuery, GetModelByIdQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private IBaseRepository<Model> _modelRepository = modelRepository;

    public async Task<GetModelByIdQueryResponse> Handle(GetModelByIdQuery request, CancellationToken cancellationToken)
    {
        var model = await _modelRepository.GetByBusinessIdAsync(request.ModelId);

        if (model == null)
        {
            return new GetModelByIdQueryResponse 
            { 
                Success = false,
                StatusCode = ResponseStatus.NotFound,
                Message = "Model was not found." 
            };
        }

        var modelDto = _mapper.Map<GetModelByIdVm>(model);

        return new GetModelByIdQueryResponse
        {
            Success = true,
            StatusCode = ResponseStatus.Success,
            Message = "Model successfully requested.",
            Model = modelDto
        };
    }
}