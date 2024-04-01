using MediatR;

namespace MB.Application.Features.Tasks.Queries.GetTasksList
{
    public class GetTasksListQuery : IRequest<List<TasksListVm>>
    {

    }
}
