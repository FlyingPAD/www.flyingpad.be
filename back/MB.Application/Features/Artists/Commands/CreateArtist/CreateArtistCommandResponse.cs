using MB.Application.Models;

namespace MB.Application.Features.Artists.Commands.CreateArtist;

public class CreateArtistCommandResponse : BaseResponse
{
    public Guid ArtistId { get; set; }
}