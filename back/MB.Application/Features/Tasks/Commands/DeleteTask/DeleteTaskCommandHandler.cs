using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Tasks.Commands.DeleteTask;

public class DeleteTaskCommandHandler(IBaseRepository<Domain.TaskAggregate.Task> taskRepository) : IRequestHandler<DeleteTaskCommand, DeleteTaskCommandResponse>
{
    private readonly IBaseRepository<Domain.TaskAggregate.Task> _taskRepository = taskRepository;

    public async Task<DeleteTaskCommandResponse> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
    {
        var task = await _taskRepository.GetByBusinessIdAsync(request.Id) 
            ?? throw new NotFoundException($"Task not found.");

        await _taskRepository.DeleteAsync(task);

        return new DeleteTaskCommandResponse
        {
            Success = true,
            Message = "Success."
        };
    }
}