using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.ModelAggregate;
using MediatR;

namespace MB.Application.Features.Models.Commands.DeleteModel;

public class DeleteModelCommandHandler(IBaseRepository<Model> modelRepository) : IRequestHandler<DeleteModelCommand, BaseResponse>
{
    private readonly IBaseRepository<Model> _modelRepository = modelRepository;

    public async Task<BaseResponse> Handle(DeleteModelCommand request, CancellationToken cancellationToken)
    {
        var model = await _modelRepository.GetByBusinessIdAsync(request.ModelId)
            ?? throw new NotFoundException("Model not found.");

        await _modelRepository.DeleteAsync(model);

        return new BaseResponse
        {
            Success = true,
            Message = "Model was deleted."
        };
    }
}