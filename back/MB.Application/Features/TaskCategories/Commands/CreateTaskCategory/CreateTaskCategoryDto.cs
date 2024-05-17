namespace MB.Application.Features.TaskCategories.Commands.CreateTaskCategory;

public class CreateTaskCategoryDto
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}
