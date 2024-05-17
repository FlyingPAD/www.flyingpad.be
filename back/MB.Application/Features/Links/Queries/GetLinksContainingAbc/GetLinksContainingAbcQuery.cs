using MediatR;

namespace MB.Application.Features.Links.Queries.GetLinksContainingAbc;

public class GetLinksContainingAbcQuery : IRequest<GetLinksContainingAbcQueryResponse>
{
    public string? Abc { get; set; } = string.Empty;
}
