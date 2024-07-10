using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Models.Commands.UpdateModel;

public class UpdateModelCommandHandler(IMapper mapper, IBaseRepository<Model> modelRepository) : IRequestHandler<UpdateModelCommand, BaseResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Model> _modelRepository = modelRepository;

    public async Task<BaseResponse> Handle(UpdateModelCommand request, CancellationToken cancellationToken)
    {
        var model = await _modelRepository.GetByBusinessIdAsync(request.ModelId);

        if (model == null)
        {
            return new BaseResponse 
            { 
                Success = false, 
                StatusCode = ResponseStatus.NotFound, 
                Message = "Model was not found." 
            };
        }

        _mapper.Map(request, model);

        await _modelRepository.UpdateAsync(model);

        return new BaseResponse
        {
            Success = true,
            StatusCode = ResponseStatus.Success,
            Message = "Model successfully updated."
        };
    }
}