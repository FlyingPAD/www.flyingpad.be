using MediatR;

namespace MB.Application.Features.Tasks.Queries.GetTaskDetails;

public class GetTaskDetailsQuery : IRequest<TaskDetailsVm>
{
    public Guid Id { get; set; }
}
