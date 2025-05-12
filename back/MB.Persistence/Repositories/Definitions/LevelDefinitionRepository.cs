using MB.Application.Interfaces.Persistence;
using MB.Domain.LevelAggregate;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories.Definitions;

public class LevelDefinitionRepository(Context context) : BaseRepository<LevelDefinition>(context), ILevelDefinitionRepository
{
    public async Task<IList<LevelDefinition>> GetAllAsync()
    {
        return await _context.Set<LevelDefinition>()
                             .OrderBy(ld => ld.LevelNumber)
                             .ToListAsync();
    }

    public async Task<LevelDefinition?> GetByLevelNumberAsync(int levelNumber)
    {
        return await _context.Set<LevelDefinition>()
                             .FirstOrDefaultAsync(ld => ld.LevelNumber == levelNumber);
    }
}