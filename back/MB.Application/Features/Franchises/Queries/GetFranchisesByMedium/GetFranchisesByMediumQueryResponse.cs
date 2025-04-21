namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMedium;

public class GetFranchisesByMediumQueryResponse : BaseResponse
{
    public List<GetFranchisesByMediumQueryDto> Franchises { get; set; } = [];
}