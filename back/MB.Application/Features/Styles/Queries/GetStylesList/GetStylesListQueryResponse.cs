using MB.Application.Responses;

namespace MB.Application.Features.Styles.Queries.GetStylesList
{
    public class GetStylesListQueryResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        /// 
        public List<StyleListVm> StylesList { get; set; } = default!;

        /// <summary>
        /// Constructor
        /// </summary>
        public GetStylesListQueryResponse() : base()
        {

        }
    }
}
