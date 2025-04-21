namespace MB.Application.Features.Medias.Queries.GetAllMedia;

public class GetAllMediaQueryResponse : BaseResponse
{
    public List<GetAllMediaQueryDto> Media { get; set; } = [];
}