namespace MB.Application.Features.Franchises.Queries.GetFranchisesByModel;

public class GetFranchisesByModelQueryResponse : BaseResponse
{
    public List<GetFranchisesByModelQueryDto> FranchisesByModel { get; set; } = [];
}