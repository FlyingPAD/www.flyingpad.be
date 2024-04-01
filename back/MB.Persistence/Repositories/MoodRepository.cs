using MB.Application.Contracts.Persistence;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories
{
    public class MoodRepository(Context context) : BaseRepository<Mood>(context), IMoodRepository
    {
        public async Task<Mood> GetOneDetailsRandom()
        {
            var ids = await _context.Moods.Select(m => m.EntityId).ToListAsync();

            var random = new Random();
            var randomId = ids[random.Next(ids.Count)];

            var randomMood = await _context.Moods.FindAsync(randomId);

            return randomMood!;
        }

        public async Task<List<Mood>> GetMoodsByTag(int? tagId)
        {
            List<Mood> moodsByTag;

            moodsByTag = await _context.Moods
                .Where(mood =>
                    mood.MoodTags != null &&
                    mood.MoodTags.Any(relation => relation.TagId == tagId))
                .OrderByDescending(mood => mood.Score)
                .ToListAsync();

            return moodsByTag;
        }

        public async Task<List<Mood>> GetMoodsByArtist(int? artistId)
        {
            List<Mood> moodsByArtist;

            moodsByArtist = await _context.Moods
                .Where(mood =>
                    mood.MoodArtists != null &&
                    mood.MoodArtists.Any(relation => relation.ArtistId == artistId))
                .OrderByDescending(mood => mood.Score)
                .ToListAsync();

            return moodsByArtist;
        }

        public async Task<List<Mood>> GetMoodsByModel(int? modelId)
        {
            List<Mood> moodsByModel;

            moodsByModel = await _context.Moods
                .Where(mood =>
                    mood.MoodModels != null &&
                    mood.MoodModels.Any(relation => relation.ModelId == modelId))
                .OrderByDescending(mood => mood.Score)
                .ToListAsync();

            return moodsByModel;
        }

        public async Task<List<Mood>> GetMoodsByModels(List<int> modelIds)
        {
            return await _context.Moods
                .Where(mood => mood.MoodModels != null && mood.MoodModels.Any(relation => modelIds.Contains(relation.ModelId)))
                .OrderByDescending(mood => mood.Score)
                .ToListAsync();
        }

        public async System.Threading.Tasks.Task UpdateScore(int? entityId, int value)
        {
            var moodToUpdate = await _context.Moods.FindAsync(entityId);

            if (moodToUpdate != null)
            {
                moodToUpdate.Score += value;

                _context.Entry(moodToUpdate).State = EntityState.Modified;

                await _context.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Mood not found with the specified ID.");
            }
        }
    }
}