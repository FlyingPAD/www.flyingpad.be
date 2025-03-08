using MB.Persistence;

namespace MB.API.Configurations;

public static class DatabaseExtensions
{
    public static async Task ResetDatabaseAsync(this IHost host)
    {
        using var scope = host.Services.CreateScope();
        var context = scope.ServiceProvider.GetService<Context>();
        if (context != null)
        {
            await context.ResetDatabaseAsync();
        }
    }
}