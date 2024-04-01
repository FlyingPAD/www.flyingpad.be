using MediatR;

namespace MB.Application.Features.TaskCategories.Queries.GetTaskCategoriesList
{
    public class GetTaskCategoriesListQuery : IRequest<List<TaskCategoryListVm>>
    {

    }
}
