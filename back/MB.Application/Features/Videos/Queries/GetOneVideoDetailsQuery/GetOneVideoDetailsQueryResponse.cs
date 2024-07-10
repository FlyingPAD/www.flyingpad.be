namespace MB.Application.Features.Videos.Queries.GetOneVideoDetailsQuery;

public class GetOneVideoDetailsQueryResponse : BaseResponse
{
    public GetOneVideoDetailsQueryVm Video { get; set; } = new GetOneVideoDetailsQueryVm();
}