using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.TagCategories.Commands.DeleteTagCategory;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Task.Commands.DeleteTask
{
    public class DeleteTagCategoryCommandHandler : IRequestHandler<DeleteTagCategoryCommand, DeleteTagCategoryCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository<TagCategory> _tagCategoryRepository;

        public DeleteTagCategoryCommandHandler(IMapper mapper, IBaseRepository<TagCategory> tagCategoryRepository)
        {
            _mapper = mapper;
            _tagCategoryRepository = tagCategoryRepository;
        }

        public async Task<DeleteTagCategoryCommandResponse> Handle(DeleteTagCategoryCommand request, CancellationToken cancellationToken)
        {
            var deleteTagCategoryCommandResponse = new DeleteTagCategoryCommandResponse();

            var validator = new DeleteTagCategoryCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                deleteTagCategoryCommandResponse.Success = false;
                deleteTagCategoryCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    deleteTagCategoryCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (deleteTagCategoryCommandResponse.Success)
            {
                var tagCategory = await _tagCategoryRepository.GetByBusinessIdAsync(request.Id);
                if (tagCategory != null)
                {
                    await _tagCategoryRepository.DeleteAsync(tagCategory);
                    deleteTagCategoryCommandResponse.Success = true;
                }
                else
                {
                    deleteTagCategoryCommandResponse.Success = false;
                    deleteTagCategoryCommandResponse.ValidationErrors = new List<string>
                    {
                        "Selected tagCategory doesn't exist."
                    };
                }
            }

            return deleteTagCategoryCommandResponse;
        }
    }
}
