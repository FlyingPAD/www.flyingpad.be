using AutoMapper;
using MediatR;
using MB.Application.Interfaces.Persistence;

namespace MB.Application.Features.Tasks.Queries.GetTasksList;

public class GetTasksListQueryHandler(IBaseRepository<Domain.TaskAggregate.Task> taskRepository, IMapper mapper) : IRequestHandler<GetTasksListQuery, List<TasksListVm>>
{
    private readonly IBaseRepository<Domain.TaskAggregate.Task> _taskRepository = taskRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<List<TasksListVm>> Handle(GetTasksListQuery request, CancellationToken cancellationToken)
    {
        var allTasks = (await _taskRepository.GetAllAsync()).OrderBy(x => x.DateStart);

        return _mapper.Map<List<TasksListVm>>(allTasks);
    }
}