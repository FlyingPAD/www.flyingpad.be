using MediatR;

namespace MB.Application.Features.Models.Commands.CreateModel;

public class CreateModelCommand : IRequest<CreateModelCommandResponse>
{
    public string Pseudonym { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
