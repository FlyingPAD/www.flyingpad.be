using MB.Application.Responses;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesList
{
    public class GetAllFranchisesQueryResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        /// 
        public List<GetAllFranchisesQueryVm> FranchisesList { get; set; } = default!;

        /// <summary>
        /// Constructor
        /// </summary>
        public GetAllFranchisesQueryResponse() : base()
        {

        }
    }
}