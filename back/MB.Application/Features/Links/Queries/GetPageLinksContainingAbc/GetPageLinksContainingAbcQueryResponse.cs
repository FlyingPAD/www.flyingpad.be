using MB.Application.Responses;

namespace MB.Application.Features.Links.Queries.GetPageLinksContainingAbc
{
    public class GetPageLinksContainingAbcQueryResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        public List<PageLinksContainingAbcVm> PageLinksContainingAbc { get; set; } = default!;
        public int TotalItems { get; set; }
        public int ItemPosition { get; set; }


        /// <summary>
        /// Constructor
        /// </summary>
        public GetPageLinksContainingAbcQueryResponse() : base()
        {

        }
    }
}
