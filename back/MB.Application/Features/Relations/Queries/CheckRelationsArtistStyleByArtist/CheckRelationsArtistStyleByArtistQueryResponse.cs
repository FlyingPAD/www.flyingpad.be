using MB.Application.Models;

namespace MB.Application.Features.Relations.Queries.CheckRelationsArtistStyleByArtist;

public class CheckRelationsArtistStyleByArtistQueryResponse : BaseResponse
{
    public int NumberOfRelations { get; set; }
}
