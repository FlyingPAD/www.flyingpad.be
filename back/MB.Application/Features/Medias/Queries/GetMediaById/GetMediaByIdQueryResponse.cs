using MB.Application.Models;

namespace MB.Application.Features.Medias.Queries.GetMediaById;

public class GetMediaByIdQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    /// 
    public GetMediaByIdVm Media { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public GetMediaByIdQueryResponse() : base()
    {

    }
}
