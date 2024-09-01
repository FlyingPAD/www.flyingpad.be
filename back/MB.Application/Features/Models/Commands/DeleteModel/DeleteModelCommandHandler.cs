using AutoMapper;
using MB.Application.Contracts.Persistence;
using MB.Application.Features.Models.Commands.DeleteModel;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Task.Commands.DeleteTask;

public class DeleteModelCommandHandler(IMapper mapper, IModelRepository modelRepository) : IRequestHandler<DeleteModelCommand, BaseResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IModelRepository _modelRepository = modelRepository;

    public async Task<BaseResponse> Handle(DeleteModelCommand request, CancellationToken cancellationToken)
    {
        var response = new BaseResponse();

        var validator = new DeleteModelCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count > 0)
        {
            response.Success = false;
            response.ValidationErrors = [];
            foreach (var error in validationResult.Errors)
            {
                response.ValidationErrors.Add(error.ErrorMessage);
            }

            return response;
        }

        var model = await _modelRepository.GetByBusinessIdAsync(request.ModelId);

        if (model != null)
        {
            await _modelRepository.DeleteModelRelations(model.EntityId);
            await _modelRepository.DeleteAsync(model);
            response.Success = true;
        }
        else
        {
            response.Success = false;
            response.ValidationErrors = ["Selected model doesn't exist."];
        }

        return response;
    }
}