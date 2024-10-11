using MB.Application.Models;
using MB.Domain.Entities;

namespace MB.Application.Features.Links.Queries.GetLinksByArtist
{
    public class GetLinksByArtistQueryResponse : BaseResponse
    {
        public IEnumerable<GetLinksByArtistQueryDto> Links { get; set; } = [];
    }
}