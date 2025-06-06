﻿using MB.Application.Exceptions;
using MB.Application.Features.Moods.Queries.GetCommonTagsByMoods;
using MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood;
using MB.Application.Features.Tags.Queries.GetTagsFullListQuery;
using MB.Application.Interfaces.Persistence.Definitions;
using MB.Domain;
using MB.Domain.MoodAggregate;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories.Definitions;

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

    public async Task<List<Mood>> GetNewMoodsAsync(CancellationToken ct)
    {
        var moods = await _context.Moods
            .AsNoTracking()
            .Where(mood => mood.IsApproved == false)
            .ToListAsync(cancellationToken: ct);

        return moods;
    }

    public async Task<List<Mood>> GetMoodsByTag(int? tagId)
    {
        if (!tagId.HasValue) return [];

        var moodsByTag = await _context.Moods
            .AsNoTracking()
            .Where(mood =>
                mood.IsApproved &&
                mood.MoodTags != null && 
                mood.MoodTags.Any(relation => relation.TagId == tagId))
            .OrderBy(mood => mood.Position == 0 ? int.MaxValue : mood.Position)
            .ToListAsync();

        return moodsByTag;
    }

    public async Task<List<Mood>> GetMoodsByTagCategory(Guid tagCategoryId)
    {
        var tagCategory = await _context.TagCategories
            .Include(tc => tc.Tags)
            .FirstOrDefaultAsync(tc => tc.BusinessId == tagCategoryId);

        if (tagCategory == null || tagCategory.Tags.Count == 0)
            return [];

        var tagIds = tagCategory.Tags.Select(tag => tag.EntityId).ToList();

        var moods = await _context.Moods
            .Where(mood => 
                mood.IsApproved &&
                mood.MoodTags != null && 
                mood.MoodTags.Any(moodTag => tagIds.Contains(moodTag.TagId)))
            .OrderBy(mood => mood.Position == 0 ? int.MaxValue : mood.Position)
            .ToListAsync();

        return moods;
    }

    public async Task<List<Mood>> GetMoodsByArtist(int? artistId)
    {
        if (!artistId.HasValue) return [];

        var moodsByArtist = await _context.Moods
            .AsNoTracking()
            .Where(mood =>
                mood.IsApproved &&
                mood.MoodArtists != null && 
                mood.MoodArtists.Any(relation => relation.ArtistId == artistId))
            .OrderBy(mood => mood.Position == 0 ? int.MaxValue : mood.Position)
            .ToListAsync();

        return moodsByArtist;
    }

    public async Task<List<Mood>> GetMoodsByModel(int? modelId)
    {
        if (!modelId.HasValue) return [];

        var moodsByModel = await _context.Moods
            .AsNoTracking()
            .Where(mood =>
                mood.IsApproved &&
                mood.MoodModels != null && 
                mood.MoodModels.Any(relation => relation.ModelId == modelId))
            .OrderBy(mood => mood.Position == 0 ? int.MaxValue : mood.Position)
            .ToListAsync();

        return moodsByModel;
    }

    public async Task<List<Mood>> GetMoodsByModels(List<int> modelIds)
    {
        if (modelIds.Count == 0) return [];

        return await _context.Moods
            .AsNoTracking()
            .Where(mood =>
                mood.IsApproved &&
                mood.MoodModels != null && 
                mood.MoodModels.Any(relation => modelIds.Contains(relation.ModelId)))
            .OrderBy(mood => mood.Position == 0 ? int.MaxValue : mood.Position)
            .ToListAsync();
    }

    public async Task UpdateScore(int? entityId, int value)
    {
        var moodToUpdate = await _context.Moods.FindAsync(entityId)
            ?? throw new NotFoundException($"Mood with ID {entityId} was not found.");

        moodToUpdate.Score += value;
        _context.Entry(moodToUpdate).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task UpdateTags(int moodId, ICollection<int> tagIds)
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

    public async Task UpdateArtists(int moodId, ICollection<int> artistIds)
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

    public async Task UpdateModels(int moodId, ICollection<int> modelIds)
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

    public async Task AddImageSpecificTags(Image image)
    {
        List<int> imageSpecificTags = [];

        var tagAllFiles = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "# All Files");
        if (tagAllFiles != null) imageSpecificTags.Add(tagAllFiles.EntityId);

        var tagImage = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Image");
        if (tagImage != null) imageSpecificTags.Add(tagImage.EntityId);

        // Handle Extensions.
        var tagBmp = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == ".bmp");
        var tagGif = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == ".gif");
        var tagJpeg = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == ".jpeg");
        var tagJpg = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == ".jpg");
        var tagPng = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == ".png");
        var tagWebp = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == ".webp");

        if (tagBmp != null && image.Extension == "bmp") imageSpecificTags.Add(tagBmp.EntityId);
        if (tagGif != null && image.Extension == "gif") imageSpecificTags.Add(tagGif.EntityId);
        if (tagJpeg != null && image.Extension == "jpeg") imageSpecificTags.Add(tagJpeg.EntityId);
        if (tagJpg != null && image.Extension == "jpg") imageSpecificTags.Add(tagJpg.EntityId);
        if (tagPng != null && image.Extension == "png") imageSpecificTags.Add(tagPng.EntityId);
        if (tagWebp != null && image.Extension == "webp") imageSpecificTags.Add(tagWebp.EntityId);

        // Handle Dimensions.
        var tagSquare = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Square ( 1:1 )");
        if (tagSquare != null && image.Height == image.Width) imageSpecificTags.Add(tagSquare.EntityId);

        // Landscape ratios
        var tagLandscape = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Landscape");
        var tagLandscape169 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Landscape ( 16:9 )");
        var tagLandscape21 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Landscape ( 2:1 )");
        var tagLandscape32 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Landscape ( 3:2 )");
        var tagLandscape43 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Landscape ( 4:3 )");
        var tagLandscape54 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Landscape ( 5:4 )");
        var tagLandscape65 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Landscape ( 6:5 )");
        var tagLandscape75 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Landscape ( 7:5 )");
        var tagLandscape87 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Landscape ( 8:7 )");

        if (tagLandscape != null && image.Height < image.Width) imageSpecificTags.Add(tagLandscape.EntityId);
        if (tagLandscape169 != null && image.Width * 9 == image.Height * 16) imageSpecificTags.Add(tagLandscape169.EntityId);
        if (tagLandscape21 != null && image.Width * 1 == image.Height * 2) imageSpecificTags.Add(tagLandscape21.EntityId);
        if (tagLandscape32 != null && image.Width * 2 == image.Height * 3) imageSpecificTags.Add(tagLandscape32.EntityId);
        if (tagLandscape43 != null && image.Width * 3 == image.Height * 4) imageSpecificTags.Add(tagLandscape43.EntityId);
        if (tagLandscape54 != null && image.Width * 4 == image.Height * 5) imageSpecificTags.Add(tagLandscape54.EntityId);
        if (tagLandscape65 != null && image.Width * 5 == image.Height * 6) imageSpecificTags.Add(tagLandscape65.EntityId);
        if (tagLandscape75 != null && image.Width * 5 == image.Height * 7) imageSpecificTags.Add(tagLandscape75.EntityId);
        if (tagLandscape87 != null && image.Width * 7 == image.Height * 8) imageSpecificTags.Add(tagLandscape87.EntityId);

        // Portrait ratios
        var tagPortrait = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Portrait");
        var tagPortrait169 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Portrait ( 9:16 )");
        var tagPortrait21 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Portrait ( 1:2 )");
        var tagPortrait32 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Portrait ( 2:3 )");
        var tagPortrait43 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Portrait ( 3:4 )");
        var tagPortrait54 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Portrait ( 4:5 )");
        var tagPortrait65 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Portrait ( 5:6 )");
        var tagPortrait75 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Portrait ( 5:7 )");
        var tagPortrait87 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Portrait ( 7:8 )");

        if (tagPortrait != null && image.Height > image.Width) imageSpecificTags.Add(tagPortrait.EntityId);
        if (tagPortrait169 != null && image.Height * 9 == image.Width * 16) imageSpecificTags.Add(tagPortrait169.EntityId);
        if (tagPortrait21 != null && image.Height * 1 == image.Width * 2) imageSpecificTags.Add(tagPortrait21.EntityId);
        if (tagPortrait32 != null && image.Height * 2 == image.Width * 3) imageSpecificTags.Add(tagPortrait32.EntityId);
        if (tagPortrait43 != null && image.Height * 3 == image.Width * 4) imageSpecificTags.Add(tagPortrait43.EntityId);
        if (tagPortrait54 != null && image.Height * 4 == image.Width * 5) imageSpecificTags.Add(tagPortrait54.EntityId);
        if (tagPortrait75 != null && image.Height * 5 == image.Width * 7) imageSpecificTags.Add(tagPortrait75.EntityId);
        if (tagPortrait65 != null && image.Height * 5 == image.Width * 6) imageSpecificTags.Add(tagPortrait65.EntityId);
        if (tagPortrait87 != null && image.Height * 7 == image.Width * 8) imageSpecificTags.Add(tagPortrait87.EntityId);

        var relations = imageSpecificTags.Select(tagId => new RelationMoodTag
        {
            MoodId = image.EntityId,
            TagId = tagId
        }).ToList();

        await _context.RMoodTag.AddRangeAsync(relations);
        await _context.SaveChangesAsync();
    }

    public async Task AddVideoSpecificTags(Video video)
    {
        List<int> videoSpecificTags = [];

        var tagAllFiles = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "# All Files");
        if (tagAllFiles != null) videoSpecificTags.Add(tagAllFiles.EntityId);

        var tagVideo = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Video");
        if (tagVideo != null) videoSpecificTags.Add(tagVideo.EntityId);

        // Handle Extensions.
        var tagMp4 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == ".mp4");
        var tagWebm = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == ".webm");

        if (tagMp4 != null && video.Extension == "mp4") videoSpecificTags.Add(tagMp4.EntityId);
        if (tagWebm != null && video.Extension == "webm") videoSpecificTags.Add(tagWebm.EntityId);

        // Handle Dimensions.
        var tagSquare = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Square ( 1:1 )");
        if (tagSquare != null && video.Height == video.Width) videoSpecificTags.Add(tagSquare.EntityId);

        // Landscape ratios
        var tagLandscape = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Landscape");
        var tagLandscape169 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Landscape ( 16:9 )");
        var tagLandscape21 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Landscape ( 2:1 )");
        var tagLandscape32 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Landscape ( 3:2 )");
        var tagLandscape43 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Landscape ( 4:3 )");
        var tagLandscape54 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Landscape ( 5:4 )");
        var tagLandscape65 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Landscape ( 6:5 )");
        var tagLandscape75 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Landscape ( 7:5 )");
        var tagLandscape87 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Landscape ( 8:7 )");

        if (tagLandscape != null && video.Height < video.Width) videoSpecificTags.Add(tagLandscape.EntityId);
        if (tagLandscape169 != null && video.Width * 9 == video.Height * 16) videoSpecificTags.Add(tagLandscape169.EntityId);
        if (tagLandscape21 != null && video.Width * 1 == video.Height * 2) videoSpecificTags.Add(tagLandscape21.EntityId);
        if (tagLandscape32 != null && video.Width * 2 == video.Height * 3) videoSpecificTags.Add(tagLandscape32.EntityId);
        if (tagLandscape43 != null && video.Width * 3 == video.Height * 4) videoSpecificTags.Add(tagLandscape43.EntityId);
        if (tagLandscape54 != null && video.Width * 4 == video.Height * 5) videoSpecificTags.Add(tagLandscape54.EntityId);
        if (tagLandscape65 != null && video.Width * 5 == video.Height * 6) videoSpecificTags.Add(tagLandscape65.EntityId);
        if (tagLandscape75 != null && video.Width * 5 == video.Height * 7) videoSpecificTags.Add(tagLandscape75.EntityId);
        if (tagLandscape87 != null && video.Width * 7 == video.Height * 8) videoSpecificTags.Add(tagLandscape87.EntityId);

        // Portrait ratios
        var tagPortrait = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Portrait");
        var tagPortrait169 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Portrait ( 9:16 )");
        var tagPortrait21 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Portrait ( 1:2 )");
        var tagPortrait32 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Portrait ( 2:3 )");
        var tagPortrait43 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Portrait ( 3:4 )");
        var tagPortrait54 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Portrait ( 4:5 )");
        var tagPortrait65 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Portrait ( 5:6 )");
        var tagPortrait75 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Portrait ( 5:7 )");
        var tagPortrait87 = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "Portrait ( 7:8 )");

        if (tagPortrait != null && video.Height > video.Width) videoSpecificTags.Add(tagPortrait.EntityId);
        if (tagPortrait169 != null && video.Height * 9 == video.Width * 16) videoSpecificTags.Add(tagPortrait169.EntityId);
        if (tagPortrait21 != null && video.Height * 1 == video.Width * 2) videoSpecificTags.Add(tagPortrait21.EntityId);
        if (tagPortrait32 != null && video.Height * 2 == video.Width * 3) videoSpecificTags.Add(tagPortrait32.EntityId);
        if (tagPortrait43 != null && video.Height * 3 == video.Width * 4) videoSpecificTags.Add(tagPortrait43.EntityId);
        if (tagPortrait54 != null && video.Height * 4 == video.Width * 5) videoSpecificTags.Add(tagPortrait54.EntityId);
        if (tagPortrait65 != null && video.Height * 5 == video.Width * 6) videoSpecificTags.Add(tagPortrait65.EntityId);
        if (tagPortrait75 != null && video.Height * 5 == video.Width * 7) videoSpecificTags.Add(tagPortrait75.EntityId);
        if (tagPortrait87 != null && video.Height * 7 == video.Width * 8) videoSpecificTags.Add(tagPortrait87.EntityId);

        var relations = videoSpecificTags.Select(tagId => new RelationMoodTag
        {
            MoodId = video.EntityId,
            TagId = tagId
        }).ToList();

        await _context.RMoodTag.AddRangeAsync(relations);
        await _context.SaveChangesAsync();
    }

    public async Task AddYouTubeVideoSpecificTags(VideoYouTube videoYouTube)
    {
        List<int> youtubeVideoSpecificTags = [];

        var tagAllFiles = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "# All Files");
        if (tagAllFiles != null) youtubeVideoSpecificTags.Add(tagAllFiles.EntityId);

        var relations = youtubeVideoSpecificTags.Select(tagId => new RelationMoodTag
        {
            MoodId = videoYouTube.EntityId,
            TagId = tagId
        }).ToList();

        await _context.RMoodTag.AddRangeAsync(relations);
        await _context.SaveChangesAsync();
    }

    public async Task AddSoundCloudAudioSpecificTags(AudioSoundCloud audioSoundCloud)
    {
        List<int> soundCloudAudioSpecificTags = [];

        var tagAllFiles = await _context.Tags.FirstOrDefaultAsync(tag => tag.Name == "# All Files");
        if (tagAllFiles != null) soundCloudAudioSpecificTags.Add(tagAllFiles.EntityId);

        var relations = soundCloudAudioSpecificTags.Select(tagId => new RelationMoodTag
        {
            MoodId = audioSoundCloud.EntityId,
            TagId = tagId
        }).ToList();

        await _context.RMoodTag.AddRangeAsync(relations);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateMultiTags(Guid[] moodIds, Guid[] tagsToAdd, Guid[] tagsToRemove)
    {
        var moodEntities = await _context.Moods
            .OfType<AuditableEntity>()
            .Where(m => moodIds.Contains(m.BusinessId))
            .ToListAsync();
        var tempMoodIds = moodEntities.Select(m => m.EntityId).ToList();

        if (tempMoodIds.Count == 0)
        {
            return;
        }

        var tagAddEntities = await _context.Tags
            .OfType<AuditableEntity>()
            .Where(t => tagsToAdd.Contains(t.BusinessId))
            .ToListAsync();
        var tagAddIds = tagAddEntities.Select(t => t.EntityId).ToList();

        var tagRemoveEntities = await _context.Tags
            .OfType<AuditableEntity>()
            .Where(t => tagsToRemove.Contains(t.BusinessId))
            .ToListAsync();
        var tagRemoveIds = tagRemoveEntities.Select(t => t.EntityId).ToList();

        var moodsWithTags = await _context.Moods
            .Where(m => tempMoodIds.Contains(m.EntityId))
            .Include(m => m.MoodTags)
            .ToListAsync();

        foreach (var mood in moodsWithTags)
        {
            var existingTagIds = mood.MoodTags?.Select(mt => mt.TagId).ToHashSet() ?? [];

            var tagsToActuallyAdd = tagAddIds.Except(existingTagIds).ToList();
            foreach (var tagId in tagsToActuallyAdd)
            {
                _context.RMoodTag.Add(new RelationMoodTag
                {
                    MoodId = mood.EntityId,
                    TagId = tagId
                });
            }

            var tagsToActuallyRemove = (mood.MoodTags ?? Enumerable.Empty<RelationMoodTag>())
                .Where(mt => tagRemoveIds.Contains(mt.TagId))
                .ToList();

            if (tagsToActuallyRemove.Count != 0)
            {
                _context.RMoodTag.RemoveRange(tagsToActuallyRemove);
            }
        }

        await _context.SaveChangesAsync();
    }

    public async Task<List<GetCommonTagsByMoodsQueryDto>> GetCommonTagsByMoods(Guid[] moodIds)
    {
        if (moodIds == null || moodIds.Length == 0)
            return [];

        var moodEntityQuery = _context.Moods
            .Where(m => moodIds.Contains(m.BusinessId))
            .Select(m => m.EntityId);

        int totalMoodsCount = await moodEntityQuery.CountAsync();

        var filteredTagsQuery = _context.RMoodTag
            .AsNoTracking()
            .Where(rmt =>
                moodEntityQuery.Contains(rmt.MoodId) &&
                rmt.Tag != null &&
                rmt.Tag!.TagCategory != null)
            .Select(rmt => new
            {
                Tag = rmt.Tag!,
                TagCategory = rmt.Tag!.TagCategory!,
                rmt.MoodId
            });

        var commonTags = await filteredTagsQuery
            .GroupBy(x => new
            {
                CategoryBusinessId = x.TagCategory!.BusinessId,
                CategoryName = x.TagCategory!.Name,
                TagBusinessId = x.Tag!.BusinessId,
                TagName = x.Tag!.Name
            })
            .Select(g => new
            {
                g.Key.CategoryBusinessId,
                g.Key.CategoryName,
                g.Key.TagBusinessId,
                g.Key.TagName,
                MoodCount = g.Select(x => x.MoodId).Distinct().Count()
            })
            .Where(x => x.MoodCount == totalMoodsCount)
            .ToListAsync();

        var result = commonTags
            .GroupBy(x => new { x.CategoryBusinessId, x.CategoryName })
            .Select(g => new GetCommonTagsByMoodsQueryDto
            {
                Category = new TagCategoryDto
                {
                    BusinessId = g.Key.CategoryBusinessId,
                    Name = g.Key.CategoryName
                },
                TagsCheckBoxes = g.Select(x => new TagsCheckBoxesDto
                {
                    BusinessId = x.TagBusinessId,
                    Name = x.TagName,
                    IsChecked = true
                }).ToList()
            })
            .ToList();

        return result;
    }
}