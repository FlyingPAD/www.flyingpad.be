using MediatR;

namespace MB.Application.Features.TagCategories.Commands.DeleteTagCategory;

public class DeleteTagCategoryCommand : IRequest<BaseResponse>
{
    public Guid TagCategoryId { get; set; }
}