using AutoMapper;
using MB.Application.Contracts.Persistence;
using MediatR;

namespace MB.Application.Features.TaskCategories.Queries.GetTaskCategoriesListWithTasks;

public class GetTaskCategoriesListWithTasksQueryHandler : IRequestHandler<GetTaskCategoriesListWithTasksQuery, List<TaskCategoryTaskListVm>>
{
    private readonly IMapper _mapper;
    private readonly ITaskCategoryRepository _taskCategoryRepository;

    public GetTaskCategoriesListWithTasksQueryHandler(IMapper mapper, ITaskCategoryRepository taskCategoryRepository)
    {
        _mapper = mapper;
        _taskCategoryRepository = taskCategoryRepository;
    }

    public async Task<List<TaskCategoryTaskListVm>> Handle(GetTaskCategoriesListWithTasksQuery request, CancellationToken cancellationToken)
    {
        var list = await _taskCategoryRepository.GetTaskCategoriesWithTasks(request.IncludeHistory);

        return _mapper.Map<List<TaskCategoryTaskListVm>>(list);
    }
}
