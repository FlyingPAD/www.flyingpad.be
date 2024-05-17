using MediatR;

namespace MB.Application.Features.Tasks.Commands.UpdateTask;

public class UpdateTaskCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
    public Guid TaskCategoryId { get; set; }
}
