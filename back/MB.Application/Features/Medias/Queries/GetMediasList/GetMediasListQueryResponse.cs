using MB.Application.Responses;

namespace MB.Application.Features.Medias.Queries.GetMediasList
{
    public class GetMediasListQueryResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        /// 
        public List<MediaListVm> MediasList { get; set; } = default!;

        /// <summary>
        /// Constructor
        /// </summary>
        public GetMediasListQueryResponse() : base()
        {

        }
    }
}
