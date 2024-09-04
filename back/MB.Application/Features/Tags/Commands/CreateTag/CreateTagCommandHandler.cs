using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Tags.Commands.CreateTag;

public class CreateTagCommandHandler(IBaseRepository<Tag> tagRepository, IBaseRepository<TagCategory> tagCategoryRepository) : IRequestHandler<CreateTagCommand, CreateTagCommandResponse>
{
    private readonly IBaseRepository<Tag> _tagRepository = tagRepository;
    private readonly IBaseRepository<TagCategory> _tagCategoryRepository = tagCategoryRepository;

    public async Task<CreateTagCommandResponse> Handle(CreateTagCommand request, CancellationToken cancellationToken)
    {
        var createTagCommandResponse = new CreateTagCommandResponse();

        var tagCategoryEntityId = await _tagCategoryRepository.GetPrimaryIdByBusinessIdAsync(request.TagCategoryId);

        var tagToCreate = new Tag { Name = request.Name, Description = request.Description, TagCategoryId = (int)tagCategoryEntityId };
        var tag = await _tagRepository.CreateAsync(tagToCreate);

        createTagCommandResponse.BusinessId = tag.BusinessId;
        createTagCommandResponse.Success = true;

        return createTagCommandResponse;
    }
}