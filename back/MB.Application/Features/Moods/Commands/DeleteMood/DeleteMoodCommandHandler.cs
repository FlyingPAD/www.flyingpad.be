using MB.Application.Interfaces;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Moods.Commands.DeleteMood;

public class DeleteMoodCommandHandler(IMoodRepository moodRepo, IFileService fileService) : IRequestHandler<DeleteMoodCommand, BaseResponse>
{
    private readonly IMoodRepository _moodRepo = moodRepo;
    private readonly IFileService _fileService = fileService;

    public async Task<BaseResponse> Handle(DeleteMoodCommand request, CancellationToken cancellationToken)
    {
        var mood = await _moodRepo.GetByBusinessIdAsync(request.MoodId)
            ?? throw new NotFoundException($"Mood with ID {request.MoodId} was not found.");

        await _moodRepo.DeleteMoodRelations(mood.EntityId);
        await _fileService.DeleteMoodAsync(mood.BusinessId, mood.Extension, mood.Type);
        await _moodRepo.DeleteAsync(mood);

        return new BaseResponse
        {
            Success = true,
            Message = "Success."
        };
    }
}