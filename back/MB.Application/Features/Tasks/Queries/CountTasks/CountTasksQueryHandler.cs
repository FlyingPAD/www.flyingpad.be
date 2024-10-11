using MB.Application.Interfaces.Persistence.Common;
using MediatR;

namespace MB.Application.Features.Tasks.Queries.CountTasks;

public class CountTasksQueryHandler(IBaseRepository<Domain.Entities.Task> taskRepository) : IRequestHandler<CountTasksQuery, CountTasksQueryResponse>
{
    private readonly IBaseRepository<Domain.Entities.Task> _taskRepository = taskRepository;

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