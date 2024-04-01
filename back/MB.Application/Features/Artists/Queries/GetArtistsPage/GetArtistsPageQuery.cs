using MediatR;

namespace MB.Application.Features.Artists.Queries.GetArtistsPage
{
    public class GetArtistsPageQuery : IRequest<GetArtistsPageQueryResponse>
    {
        public Guid? StyleId { get; set; } = null;
        public Guid? StartId { get; set; } = null;
        public string Abc { get; set; } = string.Empty;
        public int PageSize { get; set; } = 10;
    }
}