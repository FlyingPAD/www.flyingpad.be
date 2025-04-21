namespace MB.Application.Features.Styles.Queries.GetStyleById;

public class GetStyleByIdQueryResponse : BaseResponse
{
    public GetStyleByIdQueryDto Style { get; set; } = new();
}