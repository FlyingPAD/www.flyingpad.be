using MediatR;

namespace MB.Application.Features.TagCategories.Queries.GetTagCategoryById;

public class GetTagCategoryByIdQuery : IRequest<GetTagCategoryByIdQueryResponse>
{
    public Guid TagCategoryId { get; set; }
}