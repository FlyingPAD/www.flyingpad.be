using MB.Application.Responses;

namespace MB.Application.Features.Artists.Commands.CreateArtist
{
    public class CreateArtistCommandResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        public CreateArtistDto Artist { get; set; } = default!;

        /// <summary>
        /// Constructor
        /// </summary>
        public CreateArtistCommandResponse() : base()
        {

        }
    }
}
