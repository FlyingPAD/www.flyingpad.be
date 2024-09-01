using Hangfire;
using MB.API.Middlewares;
using MB.Application;
using MB.Infrastructure;
using MB.Infrastructure.Configurations;
using MB.Persistence;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Globalization;
using System.Text;

namespace MB.API;

public class Program
{
    public static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");

        var builder = WebApplication.CreateBuilder(args);

        builder.Host.UseSerilog((context, services, configuration) =>
        {
            var currentDateTime = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            configuration
                .ReadFrom.Configuration(context.Configuration)
                .ReadFrom.Services(services)
                .WriteTo.Async(a => a.File($"Logs/FlyingPAD_{currentDateTime}.txt",
                                 outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}"));
        });

        try
        {
            builder.Services.AddApplicationServices();
            builder.Services.AddInfrastructureServices(builder.Configuration);
            builder.Services.AddPersistenceServices(builder.Configuration);

            Swagger.Add(builder.Services);

            builder.Services.AddControllers();

            AddCors.Configuration(builder.Services);

            builder.Services.AddSingleton<TokenManager>();

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    var jwtKey = builder.Configuration["Jwt:Key"];
                    if (string.IsNullOrEmpty(jwtKey))
                    {
                        throw new InvalidOperationException("JWT Key is missing in the configuration.");
                    }

                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey)),
                        ValidateIssuer = true,
                        ValidIssuer = builder.Configuration["Jwt:Issuer"],
                        ValidateAudience = true,
                        ValidAudience = builder.Configuration["Jwt:Audience"]
                    };
                });

            builder.Services.AddAuthorizationBuilder()
                .AddPolicy("User", policy => policy.RequireAuthenticatedUser())
                .AddPolicy("Admin", policy => policy.RequireRole("Admin"));

            DirectoriesConfiguration.CheckDirectories();

            var app = builder.Build();

            Log.Information(" => Application Startup  ");

            Swagger.Use(app);

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors("Open");
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.UseMiddleware<ExceptionsMiddleware>();
            app.UseHangfireDashboard("/hangfire");

            // app.ResetDatabaseAsync();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "Content")),
                RequestPath = "/Content"
            });

            HangFireJobsConfiguration.ConfigureRecurringJobs(app.Services);
            app.MapHangfireDashboard();

            app.Run();
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "A fatal exception has caused the application to stop.");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}