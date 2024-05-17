using MB.Application.Responses;

namespace MB.Application.Features.Models.Queries.GetModelsList;

public class GetModelsListQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    /// 
    public List<ModelListVm> ModelsList { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public GetModelsListQueryResponse() : base()
    {

    }
}
