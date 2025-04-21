using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Moods.Commands.UpdateMoodScore;

public class UpdateMoodScoreCommandHandler(IMoodRepository repository) : IRequestHandler<UpdateMoodScoreCommand, BaseResponse>
{
    private readonly IMoodRepository _repository = repository;

    public async Task<BaseResponse> Handle(UpdateMoodScoreCommand request, CancellationToken cancellationToken)
    {
        int moodId = await _repository.GetPrimaryIdByBusinessIdAsync(request.MoodId)
            ?? throw new NotFoundException("Mood not found.");

        await _repository.UpdateScore(moodId, request.Value);

        return new BaseResponse
        {
            Success = true,
            Message = Math.Sign(request.Value) == 1 ? $"Score + {request.Value}" : $"Score {request.Value}"
        };
    }
}