using MB.Application.Responses;

namespace MB.Application.Features.Links.Queries.GetLinksContainingAbc;

public class GetLinksContainingAbcQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    /// 
    public List<LinksContainingAbcVm> LinksContainingAbc { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public GetLinksContainingAbcQueryResponse() : base()
    {

    }
}
