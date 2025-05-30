using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.TagAggregate;
using MB.Domain.TagCategoryAggregate;
using MediatR;

namespace MB.Application.Features.Tags.Commands.CreateTag;

public class CreateTagCommandHandler(IBaseRepository<Tag> tagRepository, IBaseRepository<TagCategory> tagCategoryRepository) : IRequestHandler<CreateTagCommand, CreateTagCommandResponse>
{
    private readonly IBaseRepository<Tag> _tagRepository = tagRepository;
    private readonly IBaseRepository<TagCategory> _tagCategoryRepository = tagCategoryRepository;

    public async Task<CreateTagCommandResponse> Handle(CreateTagCommand request, CancellationToken cancellationToken)
    {
        var tagCategoryEntityId = await _tagCategoryRepository.GetEntityIdByBusinessIdAsync(request.TagCategoryId, cancellationToken)
            ?? throw new NotFoundException("Tag category not found.");

        var tagToCreate = new Tag
        {
            Name = request.Name,
            Description = request.Description,
            TagCategoryId = tagCategoryEntityId
        };

        var tag = await _tagRepository.CreateAsync(tagToCreate);

        return new CreateTagCommandResponse
        {
            BusinessId = tag.BusinessId,
            Success = true,
            Message = $"{tag.Name} was created."
        };
    }
}