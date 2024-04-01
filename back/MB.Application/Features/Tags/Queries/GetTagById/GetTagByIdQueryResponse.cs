using MB.Application.Responses;

namespace MB.Application.Features.Tags.Queries.GetTagById
{
    public class GetTagByIdQueryResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        /// 
        public GetTagByIdVm Tag { get; set; } = new GetTagByIdVm();
    }
}