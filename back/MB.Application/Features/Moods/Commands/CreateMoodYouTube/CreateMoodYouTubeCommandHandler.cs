using MB.Application.Interfaces.Persistence;
using MB.Application.Interfaces.Persistence.Definitions;
using MB.Domain.MoodAggregate;
using MediatR;

namespace MB.Application.Features.Moods.Commands.CreateMoodYouTube;

public class CreateMoodYouTubeCommandHandler(IBaseRepository<VideoYouTube> videoYouTubeRepo, IMoodRepository moodRepo) : IRequestHandler<CreateMoodYouTubeCommand, CreateMoodYouTubeCommandResponse>
{
    private readonly IBaseRepository<VideoYouTube> _videoYouTubeRepo = videoYouTubeRepo;
    private readonly IMoodRepository _moodRepo = moodRepo;

    public async Task<CreateMoodYouTubeCommandResponse> Handle(CreateMoodYouTubeCommand request, CancellationToken cancellationToken)
    {
        var youTubeVideo = new VideoYouTube
        {
            Name = request.Name,
            Description = request.Description,
            Url = request.Url
        };

        var createdYouTubeVideo = await _videoYouTubeRepo.CreateAsync(youTubeVideo);
        await _moodRepo.AddYouTubeVideoSpecificTags(youTubeVideo);

        var response = new CreateMoodYouTubeCommandResponse
        {
            MoodId = createdYouTubeVideo.BusinessId,
            Success = true,
            Message = "YouTube video was created."
        };

        return response;
    }
}