using MediatR;

namespace MB.Application.Features.Tags.Commands.CreateTag
{
    public class CreateTagCommand : IRequest<CreateTagCommandResponse>
    {
        public string Name { get; set; } = string.Empty;
    }
}
