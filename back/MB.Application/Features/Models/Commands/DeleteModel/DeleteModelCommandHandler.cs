using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Models.Commands.DeleteModel;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Task.Commands.DeleteTask;

public class DeleteModelCommandHandler : IRequestHandler<DeleteModelCommand, DeleteModelCommandResponse>
{
    private readonly IMapper _mapper;
    private readonly IBaseRepository<Model> _modelRepository;

    public DeleteModelCommandHandler(IMapper mapper, IBaseRepository<Model> modelRepository)
    {
        _mapper = mapper;
        _modelRepository = modelRepository;
    }

    public async Task<DeleteModelCommandResponse> Handle(DeleteModelCommand request, CancellationToken cancellationToken)
    {
        var deleteModelCommandResponse = new DeleteModelCommandResponse();

        var validator = new DeleteModelCommandValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Count > 0)
        {
            deleteModelCommandResponse.Success = false;
            deleteModelCommandResponse.ValidationErrors = new List<string>();
            foreach (var error in validationResult.Errors)
            {
                deleteModelCommandResponse.ValidationErrors.Add(error.ErrorMessage);
            }
        }
        if (deleteModelCommandResponse.Success)
        {
            var model = await _modelRepository.GetByBusinessIdAsync(request.ModelId);
            if (model != null)
            {
                await _modelRepository.DeleteAsync(model);
                deleteModelCommandResponse.Success = true;
            }
            else
            {
                deleteModelCommandResponse.Success = false;
                deleteModelCommandResponse.ValidationErrors = new List<string>
                {
                    "Selected model doesn't exist."
                };
            }
        }

        return deleteModelCommandResponse;
    }
}
