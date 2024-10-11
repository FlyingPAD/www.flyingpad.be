using MB.Application.Models;

namespace MB.Application.Features.Styles.Queries.CountStyles;

public class CountStylesQueryResponse : BaseResponse
{
    public int TotalStyles { get; set; }
}