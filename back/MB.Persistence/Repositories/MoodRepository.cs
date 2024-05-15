using MB.Application.Contracts.Persistence;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories
{
    public class MoodRepository(Context context) : BaseRepository<Mood>(context), IMoodRepository
    {

        // Retrieves a random Mood detail from the database.
        public async Task<Mood> GetOneDetailsRandom()
        {
            // Fetch all Mood IDs from the database
            var ids = await _context.Moods.Select(m => m.EntityId).ToListAsync();

            // Generate a random index to select a Mood ID
            var random = new Random();
            var randomId = ids[random.Next(ids.Count)];

            // Find the Mood with the randomly selected ID
            var randomMood = await _context.Moods.FindAsync(randomId);

            // Return the found Mood, asserting that it's not null
            return randomMood!;
        }

        // Fetches Moods associated with a specific tag.
        public async Task<List<Mood>> GetMoodsByTag(int? tagId)
        {
            // Query Moods that have any related tags matching the specified tag ID
            var moodsByTag = await _context.Moods
                .Where(mood => mood.MoodTags != null && mood.MoodTags.Any(relation => relation.TagId == tagId))
                .OrderByDescending(mood => mood.Score)
                .ToListAsync();

            return moodsByTag;
        }

        // Fetches Moods associated with a specific artist.
        public async Task<List<Mood>> GetMoodsByArtist(int? artistId)
        {
            // Query Moods that have any related artists matching the specified artist ID
            var moodsByArtist = await _context.Moods
                .Where(mood => mood.MoodArtists != null && mood.MoodArtists.Any(relation => relation.ArtistId == artistId))
                .OrderByDescending(mood => mood.Score)
                .ToListAsync();

            return moodsByArtist;
        }

        // Fetches Moods associated with a specific model.
        public async Task<List<Mood>> GetMoodsByModel(int? modelId)
        {
            // Query Moods that have any related models matching the specified model ID
            var moodsByModel = await _context.Moods
                .Where(mood => mood.MoodModels != null && mood.MoodModels.Any(relation => relation.ModelId == modelId))
                .OrderByDescending(mood => mood.Score)
                .ToListAsync();

            return moodsByModel;
        }

        // Fetches Moods associated with any of the specified models.
        public async Task<List<Mood>> GetMoodsByModels(List<int> modelIds)
        {
            // Query Moods that have any related models matching any of the specified model IDs
            return await _context.Moods
                .Where(mood => mood.MoodModels != null && mood.MoodModels.Any(relation => modelIds.Contains(relation.ModelId)))
                .OrderByDescending(mood => mood.Score)
                .ToListAsync();
        }

        // Updates the score of a specific Mood.
        public async System.Threading.Tasks.Task UpdateScore(int? entityId, int value)
        {
            // Find the Mood by the specified ID
            var moodToUpdate = await _context.Moods.FindAsync(entityId);

            if (moodToUpdate != null)
            {
                // Increment the Mood's score by the specified value
                moodToUpdate.Score += value;

                // Mark the entity as modified
                _context.Entry(moodToUpdate).State = EntityState.Modified;

                // Save changes to the database
                await _context.SaveChangesAsync();
            }
            else
            {
                // Throw an exception if no Mood is found
                throw new KeyNotFoundException("Mood not found with the specified ID.");
            }
        }

        // Updates the set of tags associated with a specific Mood.
        public async System.Threading.Tasks.Task UpdateTags(int moodId, ICollection<int> tagIds)
        {
            // Find the Mood by ID and include its current tags
            var mood = await _context.Moods
                                     .Include(m => m.MoodTags)
                                     .FirstOrDefaultAsync(m => m.EntityId == moodId) ?? throw new ArgumentException("No mood found with the provided ID.", nameof(moodId));

            // Ensure MoodTags is never null
            var existingTagIds = mood.MoodTags?.Select(mt => mt.TagId).ToList() ?? [];

            // Determine tags to be added
            var tagsToAdd = tagIds.Except(existingTagIds).ToList();
            foreach (var tagId in tagsToAdd)
            {
                _context.RMoodTag.Add(new RelationMoodTag { MoodId = moodId, TagId = tagId });
            }

            // Determine tags to be removed
            var tagsToRemove = existingTagIds.Except(tagIds).ToList();
            foreach (var tagId in tagsToRemove)
            {
                var tagToRemove = mood.MoodTags?.FirstOrDefault(mt => mt.TagId == tagId);
                if (tagToRemove != null)
                    _context.RMoodTag.Remove(tagToRemove);
            }

            // Save changes to the database
            await _context.SaveChangesAsync();
        }
    }
}