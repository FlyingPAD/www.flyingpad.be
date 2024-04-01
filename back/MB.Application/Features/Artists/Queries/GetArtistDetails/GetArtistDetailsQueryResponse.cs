using MB.Application.Responses;

namespace MB.Application.Features.Artists.Queries.GetArtistDetails
{
    public class GetArtistDetailsQueryResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        /// 
        public GetArtistDetailsVm Artist { get; set; } = default!;

        /// <summary>
        /// Constructor
        /// </summary>
        public GetArtistDetailsQueryResponse() : base()
        {

        }
    }
}
