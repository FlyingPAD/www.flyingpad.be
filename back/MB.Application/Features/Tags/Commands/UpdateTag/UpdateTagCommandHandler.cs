using MB.Application.Contracts.Persistence.Common;
using MB.Application.Models;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Tags.Commands.UpdateTag;

public class UpdateTagCommandHandler(IBaseRepository<Tag> tagRepository, IBaseRepository<TagCategory> tagCategoryRepository) : IRequestHandler<UpdateTagCommand, BaseResponse>
{
    private readonly IBaseRepository<Tag> _tagRepository = tagRepository;
    private readonly IBaseRepository<TagCategory> _tagCategoryRepository = tagCategoryRepository;

    public async Task<BaseResponse> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
    {
        var tag = await _tagRepository.GetByBusinessIdAsync(request.TagId);

        if (tag == null)
        {
            return new BaseResponse { Success = false, Message = "Tag wasn't found :(" };
        }

        var tagCategoryEntityId = await _tagCategoryRepository.GetPrimaryIdByBusinessIdAsync(request.TagCategoryId);

        tag.Name = request.Name;
        tag.Description = request.Description;
        tag.TagCategoryId = (int)tagCategoryEntityId;

        await _tagRepository.UpdateAsync(tag);

        return new BaseResponse
        {
            Success = true,
            Message = "Update Success !",
        };
    }
}