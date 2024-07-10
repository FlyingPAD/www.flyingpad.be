namespace MB.Application.Features.Styles.Queries.GetStylesCheck;

public class GetStylesCheckQueryResponse : BaseResponse
{
    public List<GetStylesCheckQueryDto> StylesCheck { get; set; } = [];
}