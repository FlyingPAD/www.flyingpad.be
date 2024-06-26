﻿using MB.Application.Contracts.Persistence;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories;

public class MoodRepository(Context context) : BaseRepository<Mood>(context), IMoodRepository
{
    /// <summary>
    /// Retrieves a random Mood detail from the database.
    /// </summary>
    public async Task<Mood> GetOneDetailsRandom()
    {
        var ids = await _context.Moods.Select(m => m.EntityId).ToListAsync();
        var random = new Random();
        var randomId = ids[random.Next(ids.Count)];
        var randomMood = await _context.Moods.FindAsync(randomId);
        return randomMood!;
    }

    /// <summary>
    /// Fetches Moods associated with a specific tag.
    /// </summary>
    public async Task<List<Mood>> GetMoodsByTag(int? tagId)
    {
        var moodsByTag = await _context.Moods
            .Where(mood => mood.MoodTags != null && mood.MoodTags.Any(relation => relation.TagId == tagId))
            .OrderByDescending(mood => mood.Score)
            .ToListAsync();

        return moodsByTag;
    }

    /// <summary>
    /// Fetches Moods associated with a specific artist.
    /// </summary>
    public async Task<List<Mood>> GetMoodsByArtist(int? artistId)
    {
        var moodsByArtist = await _context.Moods
            .Where(mood => mood.MoodArtists != null && mood.MoodArtists.Any(relation => relation.ArtistId == artistId))
            .OrderByDescending(mood => mood.Score)
            .ToListAsync();

        return moodsByArtist;
    }

    /// <summary>
    /// Fetches Moods associated with a specific model.
    /// </summary>
    public async Task<List<Mood>> GetMoodsByModel(int? modelId)
    {
        var moodsByModel = await _context.Moods
            .Where(mood => mood.MoodModels != null && mood.MoodModels.Any(relation => relation.ModelId == modelId))
            .OrderByDescending(mood => mood.Score)
            .ToListAsync();

        return moodsByModel;
    }

    /// <summary>
    /// Fetches Moods associated with any of the specified models.
    /// </summary>
    public async Task<List<Mood>> GetMoodsByModels(List<int> modelIds)
    {
        return await _context.Moods
            .Where(mood => mood.MoodModels != null && mood.MoodModels.Any(relation => modelIds.Contains(relation.ModelId)))
            .OrderByDescending(mood => mood.Score)
            .ToListAsync();
    }

    /// <summary>
    /// Updates the score of a specific Mood.
    /// </summary>
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

    /// <summary>
    /// Updates the set of tags associated with a specific Mood.
    /// </summary>
    public async System.Threading.Tasks.Task UpdateTags(int moodId, ICollection<int> tagIds)
    {
        var mood = await _context.Moods
                                 .Include(m => m.MoodTags)
                                 .FirstOrDefaultAsync(m => m.EntityId == moodId) ?? throw new ArgumentException("No mood found with the provided ID.", nameof(moodId));

        var existingTagIds = mood.MoodTags?.Select(mt => mt.TagId).ToList() ?? [];

        var tagsToAdd = tagIds.Except(existingTagIds).ToList();
        foreach (var tagId in tagsToAdd)
        {
            _context.RMoodTag.Add(new RelationMoodTag { MoodId = moodId, TagId = tagId });
        }

        var tagsToRemove = existingTagIds.Except(tagIds).ToList();
        foreach (var tagId in tagsToRemove)
        {
            var tagToRemove = mood.MoodTags?.FirstOrDefault(mt => mt.TagId == tagId);
            if (tagToRemove != null)
                _context.RMoodTag.Remove(tagToRemove);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Updates the set of artists associated with a specific Mood.
    /// </summary>
    public async System.Threading.Tasks.Task UpdateArtists(int moodId, ICollection<int> artistIds)
    {
        var mood = await _context.Moods
                                 .Include(m => m.MoodArtists)
                                 .FirstOrDefaultAsync(m => m.EntityId == moodId) ?? throw new ArgumentException("No mood found with the provided ID.", nameof(moodId));

        var existingArtistIds = mood.MoodArtists?.Select(ma => ma.ArtistId).ToList() ?? [];

        var artistsToAdd = artistIds.Except(existingArtistIds).ToList();
        foreach (var artistId in artistsToAdd)
        {
            _context.RMoodArtist.Add(new RelationMoodArtist { MoodId = moodId, ArtistId = artistId });
        }

        var artistsToRemove = existingArtistIds.Except(artistIds).ToList();
        foreach (var artistId in artistsToRemove)
        {
            var artistToRemove = mood.MoodArtists?.FirstOrDefault(ma => ma.ArtistId == artistId);
            if (artistToRemove != null)
                _context.RMoodArtist.Remove(artistToRemove);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Updates the set of models associated with a specific Mood.
    /// </summary>
    public async System.Threading.Tasks.Task UpdateModels(int moodId, ICollection<int> modelIds)
    {
        var mood = await _context.Moods
                                 .Include(m => m.MoodModels)
                                 .FirstOrDefaultAsync(m => m.EntityId == moodId) ?? throw new ArgumentException("No mood found with the provided ID.", nameof(moodId));

        var existingModelIds = mood.MoodModels?.Select(mm => mm.ModelId).ToList() ?? [];

        var modelsToAdd = modelIds.Except(existingModelIds).ToList();
        foreach (var modelId in modelsToAdd)
        {
            _context.RMoodModel.Add(new RelationMoodModel { MoodId = moodId, ModelId = modelId });
        }

        var modelsToRemove = existingModelIds.Except(modelIds).ToList();
        foreach (var modelId in modelsToRemove)
        {
            var modelToRemove = mood.MoodModels?.FirstOrDefault(mm => mm.ModelId == modelId);
            if (modelToRemove != null)
                _context.RMoodModel.Remove(modelToRemove);
        }

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Deletes all tags associated with a specific Mood.
    /// </summary>
    public async System.Threading.Tasks.Task DeleteTags(int moodId)
    {
        var relations = await _context.RMoodTag
                                         .Where(relation => relation.MoodId == moodId)
                                         .ToListAsync();

        _context.RMoodTag.RemoveRange(relations);

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Deletes all artists associated with a specific Mood.
    /// </summary>
    public async System.Threading.Tasks.Task DeleteArtists(int moodId)
    {
        var relations = await _context.RMoodArtist
                                         .Where(relation => relation.MoodId == moodId)
                                         .ToListAsync();

        _context.RMoodArtist.RemoveRange(relations);

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Deletes all models associated with a specific Mood.
    /// </summary>
    public async System.Threading.Tasks.Task DeleteModels(int moodId)
    {
        var relations = await _context.RMoodModel
                                         .Where(relation => relation.MoodId == moodId)
                                         .ToListAsync();

        _context.RMoodModel.RemoveRange(relations);

        await _context.SaveChangesAsync();
    }
}
