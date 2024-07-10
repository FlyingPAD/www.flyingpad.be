namespace MB.Application.Features.Images.Queries;

public class GetOneImageDetailsQueryResponse : BaseResponse
{
    public GetOneImageDetailsQueryVm Image { get; set; } = new GetOneImageDetailsQueryVm();
}
