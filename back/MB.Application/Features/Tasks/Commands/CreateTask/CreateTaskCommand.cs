using MediatR;

namespace MB.Application.Features.Tasks.Commands.CreateTask;

public class CreateTaskCommand : IRequest<Guid>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
    public Guid TaskCategoryId { get; set; }
    public override string ToString()
    {
        return $"Task : {Name}; Description : {Description}; On : {DateStart.ToShortDateString()}";
    }
}
