using MB.Application.Responses;

namespace MB.Application.Features.Links.Queries.GetLinksListByCategory
{
    public class GetLinksListByCategoryQueryResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        public List<LinksListByCategoryVm> LinksListByCategory { get; set; } = default!;

        /// <summary>
        /// Constructor
        /// </summary>
        public GetLinksListByCategoryQueryResponse() : base()
        {

        }
    }
}
