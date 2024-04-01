using MB.Application.Responses;

namespace MB.Application.Features.Models.Queries.GetModelById
{
    public class GetModelByIdQueryResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        /// 
        public GetModelByIdVm Model { get; set; } = default!;

        /// <summary>
        /// Constructor
        /// </summary>
        public GetModelByIdQueryResponse() : base()
        {

        }
    }
}
