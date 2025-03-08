using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Tasks.Queries.CountTasks;

public class CountTasksQueryHandler(IBaseRepository<Domain.TaskAggregate.Task> taskRepository) : IRequestHandler<CountTasksQuery, CountTasksQueryResponse>
{
    private readonly IBaseRepository<Domain.TaskAggregate.Task> _taskRepository = taskRepository;

    public async Task<CountTasksQueryResponse> Handle(CountTasksQuery request, CancellationToken cancellationToken)
    {
        return new CountTasksQueryResponse
        {
            Success = true,
            Message = "Tasks count completed.",
            TotalTasks = await _taskRepository.CountAsync()
        };
    }
}