using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MB.Domain.TaskCategoryAggregate;
using MediatR;

namespace MB.Application.Features.TaskCategories.Queries.GetTaskCategoriesList;

public class GetTaskCategoryListQueryHandler : IRequestHandler<GetTaskCategoriesListQuery, List<TaskCategoryListVm>>
{
    private readonly IBaseRepository<TaskCategory> _taskCategoryRepository;
    private readonly IMapper _mapper;

    public GetTaskCategoryListQueryHandler(IBaseRepository<TaskCategory> taskCategoryRepository, IMapper mapper)
    {
        _taskCategoryRepository = taskCategoryRepository;
        _mapper = mapper;
    }

    public async Task<List<TaskCategoryListVm>> Handle(GetTaskCategoriesListQuery request, CancellationToken cancellationToken)
    {
        var allTaskCategories = (await _taskCategoryRepository.GetAllAsync()).OrderBy(x => x.Name);

        return _mapper.Map<List<TaskCategoryListVm>>(allTaskCategories);
    }
}
