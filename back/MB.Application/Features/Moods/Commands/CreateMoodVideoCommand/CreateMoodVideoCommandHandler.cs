using MB.Application.Interfaces.Infrastructure;
using MB.Application.Interfaces.Persistence;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Moods.Commands.CreateMoodVideo;

public class CreateMoodVideoCommandHandler(
    IFileService fileService,
    IBaseRepository<Video> videoRepository,
    IMoodRepository moodRepository) : IRequestHandler<CreateMoodVideoCommand, CreateMoodVideoCommandResponse>
{
    private readonly IFileService _fileService = fileService;
    private readonly IBaseRepository<Video> _videoRepository = videoRepository;
    private readonly IMoodRepository _moodRepository = moodRepository;

    public async Task<CreateMoodVideoCommandResponse> Handle(CreateMoodVideoCommand request, CancellationToken cancellationToken)
    {
        var video = new Video
        {
            Name = request.Name,
            Description = request.Description,
            Size = request.Size,
            Extension = request.Extension,
            Height = request.Height,
            Width = request.Width,
            Duration = request.Duration,
            Type = 2
        };

        var createdVideo = await _videoRepository.CreateAsync(video);
        await _moodRepository.AddVideoSpecificTags(video);
        await _fileService.SaveVideoAsync(createdVideo.BusinessId, request.SourceFile, request.Extension);

        var response = new CreateMoodVideoCommandResponse
        {
            MoodId = createdVideo.BusinessId,
            Success = true,
            Message = "Video created successfully."
        };

        return response;
    }
}