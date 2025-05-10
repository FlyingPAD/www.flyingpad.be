using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MB.Domain.TagCategoryAggregate;
using MediatR;

namespace MB.Application.Features.TagCategories.Commands.UpdateTagCategory;

public class UpdateTagCategoryCommandHandler(IMapper mapper, IBaseRepository<TagCategory> tagCategoryRepository) : IRequestHandler<UpdateTagCategoryCommand, BaseResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<TagCategory> _tagCategoryRepository = tagCategoryRepository;

    public async Task<BaseResponse> Handle(UpdateTagCategoryCommand request, CancellationToken cancellationToken)
    {
        var tagCategory = await _tagCategoryRepository.GetByBusinessIdAsync(request.TagCategoryId)
            ?? throw new NotFoundException("Tag category not found.");

        tagCategory = _mapper.Map(request, tagCategory);

        await _tagCategoryRepository.UpdateAsync(tagCategory);

        return new BaseResponse
        {
            Success = true,
            Message = "Tag category was updated."
        };
    }
}