using MB.Application.Responses;

namespace MB.Application.Features.Artists.Queries.GetArtistsByStyle;

public class GetArtistsByStyleQueryResponse : BaseResponse  
{
    /// <summary>
    /// Properties
    /// </summary>
    /// 
    public List<GetArtistsByStyleVm> Artists { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public GetArtistsByStyleQueryResponse() : base()
    {

    }
}
