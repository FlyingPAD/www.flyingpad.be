using MB.Application.Exceptions;
using MediatR;
using MB.Application.Interfaces.Infrastructure;
using MB.Application.Models;
using MB.Application.Interfaces.Persistence.Definitions;

namespace MB.Application.Features.Moods.Commands.DeleteMood;

public class DeleteMoodCommandHandler(IMoodRepository moodRepository, IFileService fileService) : IRequestHandler<DeleteMoodCommand, BaseResponse>
{
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly IFileService _fileService = fileService;

    public async Task<BaseResponse> Handle(DeleteMoodCommand request, CancellationToken cancellationToken)
    {
        var mood = await _moodRepository.GetByBusinessIdAsync(request.MoodId)
            ?? throw new NotFoundException($"Mood not found.");

        await _fileService.DeleteMoodAsync(mood.BusinessId, mood.Extension, mood.Type);
        await _moodRepository.DeleteAsync(mood);

        return new BaseResponse
        {
            Success = true,
            Message = "Mood was deleted."
        };
    }
}