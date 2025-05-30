using MB.Application.Features.Moods.Queries.GetCommonTagsByMoods;
using MB.Domain.MoodAggregate;

namespace MB.Application.Interfaces.Persistence.Definitions;

public interface IMoodRepository : IBaseRepository<Mood>
{
    Task<Mood> GetOneDetailsRandom();
    Task<List<Mood>> GetMoodsByTag(int? tagId);
    Task<List<Mood>> GetMoodsByTagCategory(Guid tagCategoryId);
    Task<List<Mood>> GetMoodsByArtist(int? artistId);
    Task<List<Mood>> GetMoodsByModel(int? modelId);
    Task<List<Mood>> GetMoodsByModels(List<int> modelIds);
    Task<List<GetCommonTagsByMoodsQueryDto>> GetCommonTagsByMoods(Guid[] moodIds);
    Task UpdateScore(int? entityId, int value);
    Task UpdateTags(int moodId, ICollection<int> tags);
    Task UpdateModels(int moodId, ICollection<int> modelIds);
    Task UpdateArtists(int moodId, ICollection<int> artistIds);
    Task UpdateMultiTags(Guid[] moodIds, Guid[] tagsToAdd, Guid[] tagsToRemove);
    Task AddImageSpecificTags(Image image);
    Task AddVideoSpecificTags(Video video);
    Task AddYouTubeVideoSpecificTags(VideoYouTube youTubeVideo);
    Task AddSoundCloudAudioSpecificTags(AudioSoundCloud soundCloudAudio);
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds);
    Task<List<Mood>> GetNewMoodsAsync(CancellationToken ct);
}