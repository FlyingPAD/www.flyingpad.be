using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Artists.Commands.DeleteArtist;

public class DeleteArtistCommand : IRequest<BaseResponse>
{
    public Guid BusinessId { get; set; }
}
