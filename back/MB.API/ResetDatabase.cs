using MB.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MB.API.Options;

public static class ResetDatabase
{
    public static async Task ResetDatabaseAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        try
        {
            var context = scope.ServiceProvider.GetService<Context>();

            if (context != null)
            {
                await context.Database.EnsureDeletedAsync();
                await context.Database.MigrateAsync();
            }
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync($"Exception : {ex}");
        }
    }
}