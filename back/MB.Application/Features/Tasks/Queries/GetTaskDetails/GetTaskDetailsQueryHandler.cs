using AutoMapper;
using MB.Application.Contracts.Persistence;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Tasks.Queries.GetTaskDetails;
using MediatR;

namespace MB.Application.Features.Tasks.Queries.GetTasksDetails;

public class GetTaskDetailsQueryHandler(IBaseRepository<MB.Domain.Entities.Task> taskRepository, ITaskCategoryRepository taskCategoryRepository, IMapper mapper) : IRequestHandler<GetTaskDetailsQuery, TaskDetailsVm>
{
    private readonly IBaseRepository<MB.Domain.Entities.Task> _taskRepository = taskRepository;
    private readonly ITaskCategoryRepository _taskCategoryRepository = taskCategoryRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<TaskDetailsVm> Handle(GetTaskDetailsQuery request, CancellationToken cancellationToken)
    {
        var task = await _taskRepository.GetByBusinessIdAsync(request.Id) ?? throw new InvalidOperationException("La tâche spécifiée est introuvable.");
        var taskDetailsDto = _mapper.Map<TaskDetailsVm>(task);

        if (task.TaskCategory != null)
        {
            var taskCategory = await _taskCategoryRepository.GetByBusinessIdAsync(task.TaskCategory.BusinessId);
            if (taskCategory != null)
            {
                var taskCategoryDto = _mapper.Map<TaskCategoryDto>(taskCategory);
                taskDetailsDto.TaskCategory = taskCategoryDto;
            }
        }

        return taskDetailsDto;
    }
}