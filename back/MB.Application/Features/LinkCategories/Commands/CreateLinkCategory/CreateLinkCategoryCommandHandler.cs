using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.LinkCategories.Commands.CreateLinkCategory;

public class CreateLinkCategoryCommandHandler(IBaseRepository<LinkCategory> linkCategoryRepository) : IRequestHandler<CreateLinkCategoryCommand, CreateLinkCategoryCommandResponse>
{
    private readonly IBaseRepository<LinkCategory> _linkCategoryRepository = linkCategoryRepository;

    public async Task<CreateLinkCategoryCommandResponse> Handle(CreateLinkCategoryCommand request, CancellationToken cancellationToken)
    {
        var linkCategory = new LinkCategory
        {
            Name = request.Name,
            Description = request.Description
        };

        linkCategory = await _linkCategoryRepository.CreateAsync(linkCategory);

        return new CreateLinkCategoryCommandResponse
        {
            Success = true,
            Message = "Creation successful.",
            LinkCategoryId = linkCategory.BusinessId
        };
    }
}