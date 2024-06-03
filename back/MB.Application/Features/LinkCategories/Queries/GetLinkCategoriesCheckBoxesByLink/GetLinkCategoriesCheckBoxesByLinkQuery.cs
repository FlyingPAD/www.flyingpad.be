using MediatR;

namespace MB.Application.Features.LinkCategories.Queries.GetLinkCategoriesCheckBoxesByLink
{
    public class GetLinkCategoriesCheckBoxesByLinkQuery : IRequest<GetLinkCategoriesCheckBoxesByLinkQueryResponse>
    {
        public Guid LinkId { get; set; }
    }
}
