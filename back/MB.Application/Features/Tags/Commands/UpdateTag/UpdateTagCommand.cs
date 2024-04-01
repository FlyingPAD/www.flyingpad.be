using MediatR;

namespace MB.Application.Features.Tags.Commands.UpdateTag
{
    public class UpdateTagCommand : IRequest<UpdateTagCommandResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
