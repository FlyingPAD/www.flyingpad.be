using MB.Application.Responses;

namespace MB.Application.Features.Links.Queries.GetLinksList
{
    public class GetLinksListQueryResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        /// 
        public List<LinkListVm> LinksList { get; set; } = default!;

        /// <summary>
        /// Constructor
        /// </summary>
        public GetLinksListQueryResponse() : base()
        {

        }
    }
}
