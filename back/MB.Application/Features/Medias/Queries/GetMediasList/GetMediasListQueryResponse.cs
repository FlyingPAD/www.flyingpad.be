namespace MB.Application.Features.Medias.Queries.GetMediasList;

public class GetMediasListQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    /// 
    public List<MediaListVm> Medias { get; set; } = default!;

    /// <summary>
    /// Constructor
    /// </summary>
    public GetMediasListQueryResponse() : base()
    {

    }
}
