using MediatR;

namespace MB.Application.Features.Models.Commands.CreateModel
{
    public class CreateModelCommand : IRequest<CreateModelCommandResponse>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
