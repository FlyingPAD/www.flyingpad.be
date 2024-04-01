using MB.Application.Responses;

namespace MB.Application.Features.Franchises.Queries.GetFranchiseById
{
    public class GetFranchiseByIdQueryResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        /// 
        public GetFranchiseByIdVm Franchise { get; set; } = default!;

        /// <summary>
        /// Constructor
        /// </summary>
        public GetFranchiseByIdQueryResponse() : base()
        {

        }
    }
}
