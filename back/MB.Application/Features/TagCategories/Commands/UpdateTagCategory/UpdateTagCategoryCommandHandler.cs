using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.TagCategories.Commands.UpdateTagCategory
{
    public class UpdateTagCategoryCommandHandler : IRequestHandler<UpdateTagCategoryCommand, UpdateTagCategoryCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository<TagCategory> _tagCategoryRepository;

        public UpdateTagCategoryCommandHandler(IMapper mapper, IBaseRepository<TagCategory> tagCategoryRepository)
        {
            _mapper = mapper;
            _tagCategoryRepository = tagCategoryRepository;
        }

        public async Task<UpdateTagCategoryCommandResponse> Handle(UpdateTagCategoryCommand request, CancellationToken cancellationToken)
        {
            var tagCategory = await _tagCategoryRepository.GetByBusinessIdAsync(request.Id);

            if (tagCategory == null)
            {
                return new UpdateTagCategoryCommandResponse { Success = false, Message = "TagCategory wasn't found :(" };
            }

            _mapper.Map(request, tagCategory);

            await _tagCategoryRepository.UpdateAsync(tagCategory);

            var updatedTagCategoryDto = _mapper.Map<UpdateTagCategoryDto>(tagCategory);

            return new UpdateTagCategoryCommandResponse
            {
                Success = true,
                Message = "TagCategory was Updated :)",
                UpdatedTagCategory = updatedTagCategoryDto
            };
        }

    }
}
