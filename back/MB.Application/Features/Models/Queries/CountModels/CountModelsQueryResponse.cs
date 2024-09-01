using MB.Application.Models;

namespace MB.Application.Features.Models.Queries.CountModels;

public class CountModelsQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public int ModelsCount { get; set; }

    public CountModelsQueryResponse() : base ()
    {

    }
}
