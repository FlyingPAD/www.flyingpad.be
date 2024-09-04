using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Models.Commands.DeleteModel;

public class DeleteModelCommandHandler(IModelRepository modelRepository) : IRequestHandler<DeleteModelCommand, BaseResponse>
{
    private readonly IModelRepository _modelRepository = modelRepository;

    public async Task<BaseResponse> Handle(DeleteModelCommand request, CancellationToken cancellationToken)
    {
        var model = await _modelRepository.GetByBusinessIdAsync(request.ModelId)
            ?? throw new NotFoundException($"Model with ID {request.ModelId} was not found.");

        await _modelRepository.DeleteModelRelations(model.EntityId);
        await _modelRepository.DeleteAsync(model);

        return new BaseResponse
        {
            Success = true,
            Message = "Model successfully deleted."
        };
    }
}