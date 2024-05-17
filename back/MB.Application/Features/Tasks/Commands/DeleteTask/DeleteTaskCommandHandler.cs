using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MediatR;

namespace MB.Application.Features.Tasks.Commands.DeleteTask;

public class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommand, DeleteTaskCommandResponse>
{
    private readonly IMapper _mapper;
    private readonly IBaseRepository<MB.Domain.Entities.Task> _taskRepository;

    public DeleteTaskCommandHandler(IMapper mapper, IBaseRepository<MB.Domain.Entities.Task> taskRepository)
    {
        _mapper = mapper;
        _taskRepository = taskRepository;
    }

    public async Task<DeleteTaskCommandResponse> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
    {
        var deleteTaskCommandResponse = new DeleteTaskCommandResponse();

        var validator = new DeleteTaskCommandValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Count > 0)
        {
            deleteTaskCommandResponse.Success = false;
            deleteTaskCommandResponse.ValidationErrors = new List<string>();
            foreach (var error in validationResult.Errors)
            {
                deleteTaskCommandResponse.ValidationErrors.Add(error.ErrorMessage);
            }
        }
        if (deleteTaskCommandResponse.Success)
        {
            var task = await _taskRepository.GetByBusinessIdAsync(request.Id);
            if (task != null)
            {
                await _taskRepository.DeleteAsync(task);
                deleteTaskCommandResponse.Success = true;
            }
            else
            {
                deleteTaskCommandResponse.Success = false;
                deleteTaskCommandResponse.ValidationErrors = new List<string>
                {
                    "La catégorie de lien spécifiée n'existe pas."
                };
            }
        }

        return deleteTaskCommandResponse;
    }
}
