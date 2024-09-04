using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.TaskCategories.Commands.CreateTaskCategory;

public class CreateTaskCategoryCommandHandler(IBaseRepository<TaskCategory> taskCategoryRepository) : IRequestHandler<CreateTaskCategoryCommand, CreateTaskCategoryCommandResponse>
{
    private readonly IBaseRepository<TaskCategory> _taskCategoryRepository = taskCategoryRepository;

    public async Task<CreateTaskCategoryCommandResponse> Handle(CreateTaskCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = new TaskCategory
        {
            Name = request.Name
        };

        category = await _taskCategoryRepository.CreateAsync(category);

        return new CreateTaskCategoryCommandResponse
        {
            Success = true,
            Message = "Success.",
            BusinessId = category.BusinessId
        };
    }
}