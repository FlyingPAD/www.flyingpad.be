using MediatR;

namespace MB.Application.Features.TagCategories.Commands.UpdateTagCategory;

public class UpdateTagCategoryCommand : IRequest<UpdateTagCategoryCommandResponse>
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
