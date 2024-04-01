using MB.Application.Responses;

namespace MB.Application.Features.Users.Queries.GetUserById
{
    public class GetUserByIdQueryResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        /// 
        public GetUserByIdVm User { get; set; } = default!;

        /// <summary>
        /// Constructor
        /// </summary>
        public GetUserByIdQueryResponse() : base()
        {

        }
    }
}
