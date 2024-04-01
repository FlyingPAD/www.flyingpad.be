using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Moods.Commands.UpdateMood
{
    public class UpdateMoodCommandHandler : IRequestHandler<UpdateMoodCommand, UpdateMoodCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository<Mood> _moodRepository;

        public UpdateMoodCommandHandler(IMapper mapper, IBaseRepository<Mood> moodRepository)
        {
            _mapper = mapper;
            _moodRepository = moodRepository;
        }

        public async Task<UpdateMoodCommandResponse> Handle(UpdateMoodCommand request, CancellationToken cancellationToken)
        {
            var mood = await _moodRepository.GetByBusinessIdAsync(request.Id);

            if (mood == null)
            {
                return new UpdateMoodCommandResponse { Success = false, Message = "Mood wasn't found :(" };
            }

            _mapper.Map(request, mood);

            await _moodRepository.UpdateAsync(mood);

            var updatedMoodDto = _mapper.Map<UpdateMoodDto>(mood);

            return new UpdateMoodCommandResponse
            {
                Success = true,
                Message = "Mood was Updated :)",
                UpdatedMood = updatedMoodDto
            };
        }

    }
}
