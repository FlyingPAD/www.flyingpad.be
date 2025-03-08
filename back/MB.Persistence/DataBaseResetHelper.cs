using Microsoft.EntityFrameworkCore;

namespace MB.Persistence;

public static class DatabaseResetHelper
{
    public static async Task ResetDatabaseAsync(this Context context)
    {
        ArgumentNullException.ThrowIfNull(context);

        try
        {
            await context.Database.EnsureDeletedAsync();
            await context.Database.MigrateAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"DB Reset Error : {ex}");
            throw;
        }
    }
}