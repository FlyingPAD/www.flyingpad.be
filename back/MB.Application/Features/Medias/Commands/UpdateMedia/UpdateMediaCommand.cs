using MediatR;

namespace MB.Application.Features.Medias.Commands.UpdateMedia
{
    public class UpdateMediaCommand : IRequest<UpdateMediaCommandResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
