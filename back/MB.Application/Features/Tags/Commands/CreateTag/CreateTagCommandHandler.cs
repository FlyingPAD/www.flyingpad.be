using MB.Application.Contracts.Persistence.Common;
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
        var validator = new CreateTagCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count != 0)
        {
            createTagCommandResponse.Success = false;
            createTagCommandResponse.ValidationErrors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
            return createTagCommandResponse;
        }

        var tagCategoryEntityId = await _tagCategoryRepository.GetPrimaryIdByBusinessIdAsync(request.TagCategoryId);

        var tagToCreate = new Tag { Name = request.Name, Description = request.Description, TagCategoryId = (int)tagCategoryEntityId };
        var tag = await _tagRepository.CreateAsync(tagToCreate);

        createTagCommandResponse.BusinessId = tag.BusinessId;
        createTagCommandResponse.Success = true;

        return createTagCommandResponse;
    }
}