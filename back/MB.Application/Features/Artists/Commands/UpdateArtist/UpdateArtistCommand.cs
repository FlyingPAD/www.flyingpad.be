using MB.Application.Responses;
using MediatR;

namespace MB.Application.Features.Artists.Commands.UpdateArtist;

public class UpdateArtistCommand : IRequest<BaseResponse>
{
    public Guid BusinessId { get; set; }
    public string Name { get; set; } = string.Empty;
}
