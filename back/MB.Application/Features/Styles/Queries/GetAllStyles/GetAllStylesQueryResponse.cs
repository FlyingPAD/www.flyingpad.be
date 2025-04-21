namespace MB.Application.Features.Styles.Queries.GetAllStyles;

public class GetAllStylesQueryResponse : BaseResponse
{
    public List<GetAllStylesQueryDto> Styles { get; set; } = [];
}