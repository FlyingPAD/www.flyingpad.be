using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.TaskCategories.Commands.CreateTaskCategory
{
    public class CreateTaskCategoryCommandHandler : IRequestHandler<CreateTaskCategoryCommand, CreateTaskCategoryCommandResponse>
    {
        private readonly IBaseRepository<TaskCategory> _taskCategoryRepository;
        private readonly IMapper _mapper;

        public CreateTaskCategoryCommandHandler(IMapper mapper, IBaseRepository<TaskCategory> taskCategoryRepository)
        {
            _mapper = mapper;
            _taskCategoryRepository = taskCategoryRepository;
        }

        public async Task<CreateTaskCategoryCommandResponse> Handle(CreateTaskCategoryCommand request, CancellationToken cancellationToken)
        {
            var createTaskCategoryCommandResponse = new CreateTaskCategoryCommandResponse();

            var validator = new CreateTaskCategoryCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createTaskCategoryCommandResponse.Success = false;
                createTaskCategoryCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createTaskCategoryCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createTaskCategoryCommandResponse.Success)
            {
                var category = new TaskCategory() { Name = request.Name };
                category = await _taskCategoryRepository.CreateAsync(category);
                createTaskCategoryCommandResponse.TaskCategory = _mapper.Map<CreateTaskCategoryDto>(category);
            }

            return createTaskCategoryCommandResponse;
        }
    }
}
