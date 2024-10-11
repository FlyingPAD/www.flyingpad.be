using MediatR;

namespace MB.Application.Features.Links.Queries.GetLinksByCategory;

public class GetLinksByCategoryQuery : IRequest<GetLinksByCategoryQueryResponse>
{
    public Guid LinkCategoryId { get; set; }
}