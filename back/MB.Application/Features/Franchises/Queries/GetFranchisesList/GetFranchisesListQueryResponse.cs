using MB.Application.Responses;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesList
{
    public class GetFranchisesListQueryResponse : BaseResponse
    {
        /// <summary>
        /// Properties
        /// </summary>
        /// 
        public List<FranchiseListVm> FranchisesList { get; set; } = default!;

        /// <summary>
        /// Constructor
        /// </summary>
        public GetFranchisesListQueryResponse() : base()
        {

        }
    }
}
