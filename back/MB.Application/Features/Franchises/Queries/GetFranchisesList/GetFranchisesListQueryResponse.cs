using MB.Application.Responses;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesList;

public class GetFranchisesListQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    /// 
    public List<GFLQMediaDto> Medias { get; set; } = [];

    /// <summary>
    /// Constructor
    /// </summary>
    public GetFranchisesListQueryResponse() : base()
    {

    }
}
