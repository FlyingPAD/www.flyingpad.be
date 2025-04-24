using MB.Application.Interfaces.Infrastructure;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Moods.Commands.CreateSoundCloudAudio;

public class CreateSoundCloudAudioCommandHandler
    : IRequestHandler<CreateSoundCloudAudioCommand, CreateSoundCloudAudioCommandResponse>
{
    private readonly IBaseRepository<MB.Domain.MoodAggregate.AudioSoundCloud> _baseRepo;
    private readonly IMoodRepository _moodRepo;
    private readonly ISoundCloudService _soundCloudService;

    public CreateSoundCloudAudioCommandHandler(
        IBaseRepository<MB.Domain.MoodAggregate.AudioSoundCloud> baseRepo,
        IMoodRepository moodRepo,
        ISoundCloudService soundCloudService)
    {
        _baseRepo = baseRepo;
        _moodRepo = moodRepo;
        _soundCloudService = soundCloudService;
    }

    public async Task<CreateSoundCloudAudioCommandResponse> Handle(
        CreateSoundCloudAudioCommand request,
        CancellationToken cancellationToken)
    {
        // 1) Récupérer vignette + embed via oEmbed
        var (thumbnail, embedUrl) = await _soundCloudService
            .GetOembedAsync(request.Url);

        // 2) Créer l’entité avec les deux URLs
        var soundCloudAudio = new MB.Domain.MoodAggregate.AudioSoundCloud
        {
            Name = request.Name,
            Description = request.Description,
            Url = request.Url,
            ThumbnailUrl = thumbnail,
            EmbedUrl = embedUrl
        };

        // 3) Persister
        var created = await _baseRepo.CreateAsync(soundCloudAudio);

        // 4) Tags éventuels
        await _moodRepo.AddSoundCloudAudioSpecificTags(soundCloudAudio);

        return new CreateSoundCloudAudioCommandResponse
        {
            MoodId = created.BusinessId,
            Success = true,
            Message = "SoundCloud Audio was created."
        };
    }
}