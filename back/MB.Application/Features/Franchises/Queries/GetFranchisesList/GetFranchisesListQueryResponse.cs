using MB.Application.Models;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesList;

public class GetFranchisesListQueryResponse : BaseResponse
{
    public List<GFLQMediaDto> Media { get; set; } = [];
}