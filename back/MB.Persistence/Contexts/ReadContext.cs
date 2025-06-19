using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Contexts;

public class ReadContext(DbContextOptions<ReadContext> options) : BaseContext(options)
{
    // Optionnel : empêcher toute modification accidentelle
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        throw new InvalidOperationException("ReadContext n’autorise pas SaveChanges.");
    }
}