namespace MB.Application.Features.Artists.Queries.GetArtistsByStyle;

public class GetArtistsByStyleQueryResponse : BaseResponse  
{
    public List<GetArtistsByStyleQueryDto> Artists { get; set; } = [];
}