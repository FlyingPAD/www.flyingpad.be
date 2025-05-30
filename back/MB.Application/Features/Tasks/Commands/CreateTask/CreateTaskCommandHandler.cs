using AutoMapper;
using MB.Application.Interfaces.Persistence.Definitions;
using MediatR;

namespace MB.Application.Features.Tasks.Commands.CreateTask;

public class CreateTaskCommandHandler(ITaskRepository taskRepository, IMapper mapper) : IRequestHandler<CreateTaskCommand, Guid>
{
    private readonly ITaskRepository _taskRepository = taskRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<Guid> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
    {
        var task = _mapper.Map<Domain.TaskAggregate.Task>(request);

        var businessId = Guid.NewGuid();
        task.BusinessId = businessId;

        await _taskRepository.CreateAsync(task);

        return businessId;
    }
}