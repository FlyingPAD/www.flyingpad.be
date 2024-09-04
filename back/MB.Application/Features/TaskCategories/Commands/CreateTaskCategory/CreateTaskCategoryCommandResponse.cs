using MB.Application.Models;

namespace MB.Application.Features.TaskCategories.Commands.CreateTaskCategory;

public class CreateTaskCategoryCommandResponse : BaseResponse
{
    public Guid BusinessId { get; set; }
}