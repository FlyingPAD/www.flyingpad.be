using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Models.Queries.GetModelById;

public class GetModelByIdQueryHandler : IRequestHandler<GetModelByIdQuery, GetModelByIdQueryResponse>
{
    private readonly IMapper _mapper;
    private IBaseRepository<Model> _modelRepository;

    public GetModelByIdQueryHandler(IMapper mapper, IBaseRepository<Model> modelRepository)
    {
        _mapper = mapper;
        _modelRepository = modelRepository;
    }

    public async Task<GetModelByIdQueryResponse> Handle(GetModelByIdQuery request, CancellationToken cancellationToken)
    {
        var model = await _modelRepository.GetByBusinessIdAsync(request.ModelId);

        if (model == null)
        {
            return new GetModelByIdQueryResponse { Success = false, Message = "Model wasn't found :(" };
        }

        var modelDto = _mapper.Map<GetModelByIdVm>(model);

        return new GetModelByIdQueryResponse
        {
            Success = true,
            Message = "Model was found :)",
            Model = modelDto
        };
    }
}
