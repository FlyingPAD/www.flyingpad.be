using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Application.Models;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.TagCategories.Commands.UpdateTagCategory;

public class UpdateTagCategoryCommandHandler(IMapper mapper, IBaseRepository<TagCategory> tagCategoryRepository) : IRequestHandler<UpdateTagCategoryCommand, BaseResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<TagCategory> _tagCategoryRepository = tagCategoryRepository;

    public async Task<BaseResponse> Handle(UpdateTagCategoryCommand request, CancellationToken cancellationToken)
    {
        var tagCategory = await _tagCategoryRepository.GetByBusinessIdAsync(request.TagCategoryId);

        if (tagCategory == null)
        {
            return new BaseResponse { Success = false, Message = "Tag Category was not found." };
        }

        tagCategory = _mapper.Map(request, tagCategory);

        await _tagCategoryRepository.UpdateAsync(tagCategory);

        return new BaseResponse
        {
            Success = true,
            Message = "Success.",
        };
    }
}