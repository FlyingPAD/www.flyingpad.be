using MB.Application.Models;

namespace MB.Application.Features.Styles.Queries.GetStyleById;

public class GetStyleByIdQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    /// 
    public GetStyleByIdVm Style { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public GetStyleByIdQueryResponse() : base()
    {

    }
}
