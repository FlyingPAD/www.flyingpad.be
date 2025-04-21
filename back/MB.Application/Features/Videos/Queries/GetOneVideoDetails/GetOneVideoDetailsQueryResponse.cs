namespace MB.Application.Features.Videos.Queries.GetOneVideoDetails;

public class GetOneVideoDetailsQueryResponse : BaseResponse
{
    public GetOneVideoDetailsQueryDto Video { get; set; } = new();
}