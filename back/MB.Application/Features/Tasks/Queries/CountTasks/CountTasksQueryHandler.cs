using MB.Application.Interfaces.Persistence.Common;
using MediatR;

namespace MB.Application.Features.Tasks.Queries.CountTasks;

public class CountTasksQueryHandler : IRequestHandler<CountTasksQuery, CountTasksQueryResponse>
{
    private readonly IBaseRepository<Domain.Entities.Task> _taskRepository;

    public CountTasksQueryHandler(IBaseRepository<Domain.Entities.Task> taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task<CountTasksQueryResponse> Handle(CountTasksQuery request, CancellationToken cancellationToken)
    {
        var tasksCount = await _taskRepository.CountAsync();

        return new CountTasksQueryResponse
        {
            Success = true,
            Message = $"Total Tasks : {tasksCount}",
            TasksCount = tasksCount
        };
    }
}