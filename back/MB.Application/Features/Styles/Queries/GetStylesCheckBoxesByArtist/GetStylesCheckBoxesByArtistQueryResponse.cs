namespace MB.Application.Features.Styles.Queries.GetStylesCheckBoxesByArtist;

public class GetStylesCheckBoxesByArtistQueryResponse : BaseResponse
{
    public List<GetStylesCheckBoxesByArtistQueryDto> Styles { get; set; } = [];
}