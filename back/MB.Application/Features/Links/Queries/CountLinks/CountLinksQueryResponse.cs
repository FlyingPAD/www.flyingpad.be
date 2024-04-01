using MB.Application.Responses;

namespace MB.Application.Features.Links.Queries.CountLinks
{
    public class CountLinksQueryResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        public int LinksCount { get; set; }

        public CountLinksQueryResponse() : base ()
        {

        }
    }
}
