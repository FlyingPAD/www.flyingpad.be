using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Moods.Commands.CreateMood;

public class CreateMoodCommandHandler(IMapper mapper, IBaseRepository<Mood> moodRepository) : IRequestHandler<CreateMoodCommand, CreateMoodCommandResponse>
{
    private readonly IBaseRepository<Mood> _moodRepository = moodRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<CreateMoodCommandResponse> Handle(CreateMoodCommand request, CancellationToken cancellationToken)
    {
        var createMoodCommandResponse = new CreateMoodCommandResponse();

        var validator = new CreateMoodCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count > 0)
        {
            createMoodCommandResponse.Success = false;
            createMoodCommandResponse.ValidationErrors = [];
            foreach (var error in validationResult.Errors)
            {
                createMoodCommandResponse.ValidationErrors.Add(error.ErrorMessage);
            }
        }
        if (createMoodCommandResponse.Success)
        {
            var mood = new Mood() { Name = request.Name };
            mood = await _moodRepository.CreateAsync(mood);
            createMoodCommandResponse.Mood = _mapper.Map<CreateMoodDto>(mood);
        }

        return createMoodCommandResponse;
    }
}
