using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Common;
using MediatR;

namespace MB.Application.Features.Tasks.Commands.DeleteTask;

public class DeleteTaskCommandHandler(IBaseRepository<Domain.Entities.Task> taskRepository) : IRequestHandler<DeleteTaskCommand, DeleteTaskCommandResponse>
{
    private readonly IBaseRepository<MB.Domain.Entities.Task> _taskRepository = taskRepository;

    public async Task<DeleteTaskCommandResponse> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
    {
        var task = await _taskRepository.GetByBusinessIdAsync(request.Id) ?? throw new NotFoundException($"Task with ID {request.Id} was not found.");

        await _taskRepository.DeleteAsync(task);

        return new DeleteTaskCommandResponse
        {
            Success = true,
            Message = "Success."
        };
    }
}