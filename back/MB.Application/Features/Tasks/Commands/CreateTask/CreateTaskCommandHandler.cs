using AutoMapper;
using MB.Application.Contracts.Persistence;
using MediatR;

namespace MB.Application.Features.Tasks.Commands.CreateTask
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, Guid>
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;

        public CreateTaskCommandHandler(ITaskRepository taskRepository, IMapper mapper)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var task = _mapper.Map<MB.Domain.Entities.Task>(request);

            // Générer un nouvel identifiant métier (Guid) pour la tâche

            var businessId = Guid.NewGuid();
            task.BusinessId = businessId;

            var validator = new CreateTaskCommandValidator(_taskRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new Exceptions.ValidationException(validationResult);

            // Enregistrer la tâche dans la base de données

            task = await _taskRepository.CreateAsync(task);

            // Retourner l'identifiant métier (Guid) de la tâche créée

            return businessId;
        }
    }
}
