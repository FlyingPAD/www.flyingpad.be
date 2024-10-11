using MediatR;

namespace MB.Application.Features.Links.Queries.GetLinksByModel
{
    public class GetLinksByModelQuery : IRequest<GetLinksByModelQueryResponse>
    {
        public Guid ModelId { get; set; }
    }
}