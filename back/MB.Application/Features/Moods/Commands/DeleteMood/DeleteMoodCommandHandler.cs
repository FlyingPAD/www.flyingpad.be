using MB.Application.Contracts;
using MB.Application.Contracts.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Moods.Commands.DeleteMood;

public class DeleteMoodCommandHandler(IMoodRepository moodRepo, IFileService fileService) : IRequestHandler<DeleteMoodCommand, BaseResponse>
{
    private readonly IMoodRepository _moodRepo = moodRepo;
    private readonly IFileService _fileService = fileService;

    public async Task<BaseResponse> Handle(DeleteMoodCommand request, CancellationToken cancellationToken)
    {
        var response = new BaseResponse();
        var validator = new DeleteMoodCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count > 0)
        {
            response.ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
            return response;
        }

        var mood = await _moodRepo.GetByBusinessIdAsync(request.MoodId);

        if (mood != null)
        {
            response.Success = true;

            // Delete Existing Relations
            await _moodRepo.DeleteTags(mood.EntityId);
            await _moodRepo.DeleteArtists(mood.EntityId);
            await _moodRepo.DeleteModels(mood.EntityId);

            // Delete Files
            await _fileService.DeleteMoodAsync("Content", mood.BusinessId, mood.Extension);

            // Delete Mood
            await _moodRepo.DeleteAsync(mood);

            response.Message = "Mood deleted successfully.";
        }
        else
        {
            response.ValidationErrors.Add("Mood was not found.");
        }

        return response;
    }
}