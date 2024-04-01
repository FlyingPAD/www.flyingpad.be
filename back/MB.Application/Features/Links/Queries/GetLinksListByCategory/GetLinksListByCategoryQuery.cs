using MediatR;

namespace MB.Application.Features.Links.Queries.GetLinksListByCategory
{
    public class GetLinksListByCategoryQuery : IRequest<GetLinksListByCategoryQueryResponse>
    {
        public Guid LinkCategoryId { get; set; }
    }
}
