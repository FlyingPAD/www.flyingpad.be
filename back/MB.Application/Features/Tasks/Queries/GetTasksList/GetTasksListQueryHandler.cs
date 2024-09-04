using AutoMapper;
using MediatR;
using MB.Application.Interfaces.Persistence.Common;

namespace MB.Application.Features.Tasks.Queries.GetTasksList;

public class GetTasksListQueryHandler(IBaseRepository<Domain.Entities.Task> taskRepository, IMapper mapper) : IRequestHandler<GetTasksListQuery, List<TasksListVm>>
{
    private readonly IBaseRepository<Domain.Entities.Task> _taskRepository = taskRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<List<TasksListVm>> Handle(GetTasksListQuery request, CancellationToken cancellationToken)
    {
        var allTasks = (await _taskRepository.GetAllAsync()).OrderBy(x => x.DateStart);

        return _mapper.Map<List<TasksListVm>>(allTasks);
    }
}
