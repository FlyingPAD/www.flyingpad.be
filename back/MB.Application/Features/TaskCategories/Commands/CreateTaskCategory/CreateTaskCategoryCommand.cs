using MediatR;

namespace MB.Application.Features.TaskCategories.Commands.CreateTaskCategory
{
    public class CreateTaskCategoryCommand : IRequest<CreateTaskCategoryCommandResponse>
    {
        public string Name { get; set; } = string.Empty;
    }
}
