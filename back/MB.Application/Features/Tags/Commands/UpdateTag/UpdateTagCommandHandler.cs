﻿using MediatR;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.TagAggregate;
using MB.Domain.TagCategoryAggregate;
using MB.Application.Models;

namespace MB.Application.Features.Tags.Commands.UpdateTag;

public class UpdateTagCommandHandler(IBaseRepository<Tag> tagRepository, IBaseRepository<TagCategory> tagCategoryRepository) : IRequestHandler<UpdateTagCommand, BaseResponse>
{
    private readonly IBaseRepository<Tag> _tagRepository = tagRepository;
    private readonly IBaseRepository<TagCategory> _tagCategoryRepository = tagCategoryRepository;

    public async Task<BaseResponse> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
    {
        var tag = await _tagRepository.GetByBusinessIdAsync(request.TagId, cancellationToken)
                  ?? throw new NotFoundException("Tag not found.");

        var tagCategoryEntityId = await _tagCategoryRepository.GetEntityIdByBusinessIdAsync(request.TagCategoryId, cancellationToken)
                  ?? throw new NotFoundException("Tag category not found.");

        tag.Name = request.Name;
        tag.Description = request.Description;
        tag.TagCategoryId = tagCategoryEntityId;

        await _tagRepository.UpdateAsync(tag);

        return new BaseResponse
        {
            Success = true,
            Message = "Tag was updated."
        };
    }
}