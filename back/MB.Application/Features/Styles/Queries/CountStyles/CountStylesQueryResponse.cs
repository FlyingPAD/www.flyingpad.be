using MB.Application.Models;

namespace MB.Application.Features.Styles.Queries.CountStyles;

public class CountStylesQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public int StylesCount { get; set; }

    public CountStylesQueryResponse() : base ()
    {

    }
}
