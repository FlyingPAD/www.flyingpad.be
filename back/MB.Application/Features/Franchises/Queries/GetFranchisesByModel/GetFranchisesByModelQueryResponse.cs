namespace MB.Application.Features.Franchises.Queries.GetFranchisesByModel;

public class GetFranchisesByModelQueryResponse : BaseResponse
{
    public List<GetFranchisesByModelQueryVm> FranchisesByModel { get; set; } = [];
}
