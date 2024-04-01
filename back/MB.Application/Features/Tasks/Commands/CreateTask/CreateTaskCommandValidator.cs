using FluentValidation;
using MB.Application.Contracts.Persistence;

namespace MB.Application.Features.Tasks.Commands.CreateTask
{
    public class CreateTaskCommandValidator : AbstractValidator<CreateTaskCommand>
    {
        private readonly ITaskRepository _taskRepository;
        public CreateTaskCommandValidator(ITaskRepository taskRepository) 
        {
            _taskRepository = taskRepository;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");

            RuleFor(p => p.DateStart)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(DateTime.Now);

            RuleFor(e => e)
                .MustAsync(TaskNameAndDateUnique)
                .WithMessage("A task with the same name & date already exists.");
        }

        private async Task<bool> TaskNameAndDateUnique(CreateTaskCommand command, CancellationToken token)
        {
            return !await _taskRepository.IsTaskNameAndDateUnique(command.Name, command.DateStart);
        }
    }
}