using MB.Persistence;
using Microsoft.EntityFrameworkCore;

namespace MB.API.Options
{
    public static class ResetDatabase
    {
        /// <summary>
        /// Resets the database to its initial state, if needed. 
        /// Typically used during development.
        /// </summary>
        /// <param name="app">The WebApplication instance to configure.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public static async Task ResetDatabaseAsync(this WebApplication app)
        {
            // Create a new scope to retrieve services for database reset.

            using var scope = app.Services.CreateScope();

            try
            {
                // Retrieve the database context.

                var context = scope.ServiceProvider.GetService<Context>();

                if (context != null)
                {
                    // Delete the database if it exists and reapply migrations to reset it.

                    await context.Database.EnsureDeletedAsync();
                    await context.Database.MigrateAsync();
                }
            }
            catch (Exception ex)
            {
                // Output the exception to the console if an error occurs during the reset process.

                await Console.Out.WriteLineAsync($"Exception : {ex}");
            }
        }
    }
}