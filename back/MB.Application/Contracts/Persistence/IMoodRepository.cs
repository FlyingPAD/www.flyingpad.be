﻿using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;

namespace MB.Application.Contracts.Persistence;

public interface IMoodRepository : IBaseRepository<Mood>
{
    Task<Mood> GetOneDetailsRandom();
    Task<List<Mood>> GetMoodsByTag(int? styleId);
    Task<List<Mood>> GetMoodsByArtist(int? artistId);
    Task<List<Mood>> GetMoodsByModel(int? modelId);
    Task<List<Mood>> GetMoodsByModels(List<int> modelIds);
    System.Threading.Tasks.Task UpdateScore(int? entityId, int value);
    System.Threading.Tasks.Task UpdateTags(int moodId, ICollection<int> tags);
    System.Threading.Tasks.Task DeleteModels(int moodId);
    System.Threading.Tasks.Task DeleteArtists(int moodId);
    System.Threading.Tasks.Task DeleteTags(int moodId);
    System.Threading.Tasks.Task UpdateModels(int moodId, ICollection<int> modelIds);
    System.Threading.Tasks.Task UpdateArtists(int moodId, ICollection<int> artistIds);
}