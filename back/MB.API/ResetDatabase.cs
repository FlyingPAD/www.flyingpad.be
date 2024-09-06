using MB.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MB.API;

public static class ResetDatabase
{
    public static async Task ResetDatabaseAsync(this WebApplication application)
    {
        using var scope = application.Services.CreateScope();

        try
        {
            var context = scope.ServiceProvider.GetService<Context>();

            if (context != null)
            {
                await context.Database.EnsureDeletedAsync();
                await context.Database.MigrateAsync();
            }
        }
        catch (Exception exception)
        {
            await Console.Out.WriteLineAsync($"Error : {exception}");
        }
    }
}