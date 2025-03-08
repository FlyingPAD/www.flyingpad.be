using Hangfire;
using MB.API.Configurations;
using MB.API.Middlewares;
using MB.Application;
using MB.Infrastructure;
using MB.Persistence;
using Serilog;

namespace MB.API;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Host.ConfigureCustomSerilog();
        builder.ConfigureDefaultCulture();

        try
        {
            builder.Services.AddApplicationServices();
            builder.Services.AddInfrastructureServices(builder.Configuration);
            builder.Services.AddPersistenceServices(builder.Configuration);

            builder.Services.AddCustomHangfire(builder.Configuration);
            builder.Services.AddCustomSwagger();
            builder.Services.AddControllers();
            builder.Services.AddCustomCors();
            builder.Services.AddSingleton<TokenManager>();
            builder.Services.AddJwtAuthentication(builder.Configuration);
            builder.Services.AddAuthorizationBuilder()
                .AddPolicy("User", policy => policy.RequireAuthenticatedUser())
                .AddPolicy("Admin", policy => policy.RequireRole("Admin"));

            var app = builder.Build();

            Log.Information(" => Application Startup.");

            app.CheckRequiredDirectories();

            app.UseCustomSwagger();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseMiddleware<ExceptionsMiddleware>();
            app.UseCors("Open");
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.UseHangfireDashboard("/hangfire");

            app.UseCustomStaticFiles();
            app.UseCustomRecurringJobs();

            app.MapHangfireDashboard();

            // Warning ! Optional DB Reset ( DEV Only )
            // await app.ResetDatabaseAsync();

            await app.RunAsync();
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Fatal Exception !! Application Stop.");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}