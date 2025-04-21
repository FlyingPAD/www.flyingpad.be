namespace MB.Application.Features.Franchises.Queries.GetFranchiseById;

public class GetFranchiseByIdQueryResponse : BaseResponse
{
    public GetFranchiseByIdQueryDto Franchise { get; set; } = new();
}