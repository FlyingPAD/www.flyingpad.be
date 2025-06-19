using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Contexts;

public class WriteContext(DbContextOptions<WriteContext> options) : BaseContext(options)
{
    // Vous n’avez rien d’autre à ajouter : SaveChangesAsync() et OnModelCreating
    // sont hérités de BaseContext
}