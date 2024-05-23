using MediatR;

namespace MB.Application.Features.Tags.Queries.GetTagsByCategory
{
    public class GetTagsByCategoryQuery : IRequest<GetTagsByCategoryQueryResponse>
    {
        public Guid CategoryId { get; set; }
    }
}