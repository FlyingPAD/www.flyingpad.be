using MB.Application.Responses;

namespace MB.Application.Features.Artists.Queries.GetArtist;

public class GetArtistQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    /// 
    public GetArtistVm Artist { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public GetArtistQueryResponse() : base()
    {

    }
}
