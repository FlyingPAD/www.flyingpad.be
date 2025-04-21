namespace MB.Application.Features.Models.Queries.GetModelsByFranchise;

public class GetModelsByFranchiseQueryResponse : BaseResponse
{
    public List<GetModelsByFranchiseQueryDto> ModelsByFranchise { get; set; } = [];
}