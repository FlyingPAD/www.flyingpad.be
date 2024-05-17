using MediatR;

namespace MB.Application.Features.LinkCategories.Queries.GetLinkCategoryById;

public class GetLinkCategoryByIdQuery : IRequest<GetLinkCategoryByIdQueryResponse>
{
    public Guid LinkCategoryId { get; set; }
}