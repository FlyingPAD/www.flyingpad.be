using MB.Application.Features.Moods.Queries.GetCommonTagsByMoods;
using MB.Domain.MoodAggregate;

namespace MB.Application.Interfaces.Persistence;

public interface IMoodRepository : IBaseRepository<Mood>
{
    Task<Mood> GetOneDetailsRandom();
    Task<List<Mood>> GetMoodsByTag(int? tagId);
    Task<List<Mood>> GetMoodsByTagCategory(Guid tagCategoryId);
    Task<List<Mood>> GetMoodsByArtist(int? artistId);
    Task<List<Mood>> GetMoodsByModel(int? modelId);
    Task<List<Mood>> GetMoodsByModels(List<int> modelIds);
    Task<List<GetCommonTagsByMoodsQueryDto>> GetCommonTagsByMoods(Guid[] moodIds);
    System.Threading.Tasks.Task UpdateScore(int? entityId, int value);
    System.Threading.Tasks.Task UpdateTags(int moodId, ICollection<int> tags);
    System.Threading.Tasks.Task UpdateModels(int moodId, ICollection<int> modelIds);
    System.Threading.Tasks.Task UpdateArtists(int moodId, ICollection<int> artistIds);
    System.Threading.Tasks.Task UpdateMultiTags(Guid[] moodIds, Guid[] tagsToAdd, Guid[] tagsToRemove);
    System.Threading.Tasks.Task AddImageSpecificTags(Image image);
    System.Threading.Tasks.Task AddVideoSpecificTags(Video video);
    System.Threading.Tasks.Task AddYouTubeVideoSpecificTags(VideoYouTube youTubeVideo);
}