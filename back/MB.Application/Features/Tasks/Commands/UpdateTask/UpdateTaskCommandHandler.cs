using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Tasks.Commands.UpdateTask;

public class UpdateTaskCommandHandler(IMapper mapper, IBaseRepository<Domain.TaskAggregate.Task> taskRepository) : IRequestHandler<UpdateTaskCommand, Unit>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Domain.TaskAggregate.Task> _taskRepository = taskRepository;

    public async Task<Unit> Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
    {
        var taskToUpdate = await _taskRepository.GetByBusinessIdAsync(request.Id) ?? throw new InvalidOperationException("La tâche spécifiée est introuvable.");
        _mapper.Map(request, taskToUpdate, typeof(UpdateTaskCommand), typeof(Domain.TaskAggregate.Task));

        await _taskRepository.UpdateAsync(taskToUpdate);

        return Unit.Value;
    }
}