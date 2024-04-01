using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.TagCategories.Commands.CreateTagCategory
{
    public class CreateTagCategoryCommandHandler : IRequestHandler<CreateTagCategoryCommand, CreateTagCategoryCommandResponse>
    {
        private readonly IBaseRepository<TagCategory> _tagCategoryRepository;
        private readonly IMapper _mapper;

        public CreateTagCategoryCommandHandler(IMapper mapper, IBaseRepository<TagCategory> tagCategoryRepository)
        {
            _mapper = mapper;
            _tagCategoryRepository = tagCategoryRepository;
        }

        public async Task<CreateTagCategoryCommandResponse> Handle(CreateTagCategoryCommand request, CancellationToken cancellationToken)
        {
            var createTagCategoryCommandResponse = new CreateTagCategoryCommandResponse();

            var validator = new CreateTagCategoryCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createTagCategoryCommandResponse.Success = false;
                createTagCategoryCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createTagCategoryCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createTagCategoryCommandResponse.Success)
            {
                var tagCategory = new TagCategory() { Name = request.Name };
                tagCategory = await _tagCategoryRepository.CreateAsync(tagCategory);
                createTagCategoryCommandResponse.TagCategory = _mapper.Map<CreateTagCategoryDto>(tagCategory);
            }

            return createTagCategoryCommandResponse;
        }
    }
}
