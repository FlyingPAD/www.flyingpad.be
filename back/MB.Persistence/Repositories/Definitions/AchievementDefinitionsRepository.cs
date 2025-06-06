﻿using MB.Application.Interfaces.Persistence.Definitions;
using MB.Domain.AchievementAggregate;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories.Definitions;

public class AchievementDefinitionsRepository(Context context) : BaseRepository<AchievementDefinition>(context), IAchievementDefinitionsRepository
{
    public async Task<IList<AchievementDefinition>> GetByBusinessIdsAsync(IEnumerable<Guid> businessIds)
    {
        return await _context.Set<AchievementDefinition>()
            .AsNoTracking()
            .Where(d => businessIds.Contains(d.BusinessId))
            .ToListAsync();
    }

    public async Task<AchievementDefinition?> GetByCodeAsync(string code)
    {
        return await _context.Set<AchievementDefinition>()
            .AsNoTracking()
            .FirstOrDefaultAsync(a => a.Code == code);
    }

    public async Task<IList<AchievementDefinition>> GetByCodesAsync(IEnumerable<string> codes)
    {
        return await _context.Set<AchievementDefinition>()
            .AsNoTracking()
            .Where(a => codes.Contains(a.Code))
            .ToListAsync();
    }
}