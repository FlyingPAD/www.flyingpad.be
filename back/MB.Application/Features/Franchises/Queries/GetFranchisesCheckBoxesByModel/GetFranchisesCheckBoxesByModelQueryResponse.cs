using MB.Application.Models;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesCheckBoxesByModel
{
    public class GetFranchisesCheckBoxesByModelQueryResponse : BaseResponse
    {
        public List<GetFranchisesCheckBoxesByModelQueryDto> Franchises { get; set; } = [];
    }
}