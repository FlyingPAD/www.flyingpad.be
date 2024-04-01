using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Moods.Commands.DeleteMood;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Task.Commands.DeleteTask
{
    public class DeleteMoodCommandHandler : IRequestHandler<DeleteMoodCommand, DeleteMoodCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository<Mood> _moodRepository;

        public DeleteMoodCommandHandler(IMapper mapper, IBaseRepository<Mood> moodRepository)
        {
            _mapper = mapper;
            _moodRepository = moodRepository;
        }

        public async Task<DeleteMoodCommandResponse> Handle(DeleteMoodCommand request, CancellationToken cancellationToken)
        {
            var deleteMoodCommandResponse = new DeleteMoodCommandResponse();

            var validator = new DeleteMoodCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                deleteMoodCommandResponse.Success = false;
                deleteMoodCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    deleteMoodCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (deleteMoodCommandResponse.Success)
            {
                var mood = await _moodRepository.GetByBusinessIdAsync(request.MoodId);
                if (mood != null)
                {
                    await _moodRepository.DeleteAsync(mood);
                    deleteMoodCommandResponse.Success = true;
                }
                else
                {
                    deleteMoodCommandResponse.Success = false;
                    deleteMoodCommandResponse.ValidationErrors = new List<string>
                    {
                        "Selected mood doesn't exist."
                    };
                }
            }

            return deleteMoodCommandResponse;
        }
    }
}
