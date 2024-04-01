using MediatR;

namespace MB.Application.Features.Links.Queries.GetPageLinksContainingAbc
{
    public class GetPageLinksContainingAbcQuery : IRequest<GetPageLinksContainingAbcQueryResponse>
    {
        public string? Abc { get; set; } = string.Empty;
        public Guid StartId { get; set; }
        public int PageSize { get; set; } 
        public bool IsFirstItem { get; set; }
    }
}
