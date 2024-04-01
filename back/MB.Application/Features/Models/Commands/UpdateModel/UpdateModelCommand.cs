using MediatR;

namespace MB.Application.Features.Models.Commands.UpdateModel
{
    public class UpdateModelCommand : IRequest<UpdateModelCommandResponse>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
