using Hangfire;
using MB.API.Configuration;
using MB.API.Handlers;
using MB.Application;
using MB.Application.Security;
using MB.Infrastructure;
using MB.Infrastructure.Configurations;
using MB.Persistence;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Text;

namespace MB.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Builder Creation
            var builder = WebApplication.CreateBuilder(args);

            // Serilog Initialization
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
                // ------------------------------------------------------------------------------------
                // Add application core services.
                builder.Services.AddApplicationServices();

                // Add infrastructure services.
                builder.Services.AddInfrastructureServices(builder.Configuration);

                // Add persistence services.
                builder.Services.AddPersistenceServices(builder.Configuration);

                // ------------------------------------------------------------------------------------
                // Add Swagger for the API documentation.
                Swagger.Add(builder.Services);

                // Add controllers to the service collection to handle incoming HTTP requests.
                builder.Services.AddControllers();

                // Add CORS ( Cross-Origin Resource Sharing ).
                AddCors.Configuration(builder.Services);

                // Add a singleton service for managing JWT tokens.
                builder.Services.AddSingleton<TokenManager>();

                // Add JWT authentication with the necessary parameters and token validation.
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

                // Configure authorization policies for different user roles within the application.
                builder.Services.AddAuthorizationBuilder()
                    .AddPolicy("User", policy => policy.RequireAuthenticatedUser())
                    .AddPolicy("Admin", policy => policy.RequireRole("Admin"));

                // Ensure necessary directories are present for the application's needs.
                DirectoriesConfiguration.CheckDirectories();

                // ------------------------------------------------------------------------------------
                // Build Application
                var app = builder.Build();

                Log.Information("                         ");
                Log.Information(" ------------------------");
                Log.Information(" => Application Startup  ");
                Log.Information(" ------------------------");
                Log.Information("                         ");

                // Use Swagger ( check 'Configuration/Swagger' )
                Swagger.Use(app);

                // Configure common middleware components.
                app.UseHttpsRedirection();
                app.UseRouting();
                app.UseCors("Open");
                app.UseAuthentication();
                app.UseAuthorization();

                // Map controller routes to handle incoming HTTP requests via controller actions.
                app.MapControllers();

                // Custom Middlewares.
                app.UseMiddleware<ExceptionHandler>();
                app.UseHangfireDashboard("/hangfire", new DashboardOptions
                {
                    Authorization = new[] { new HangfireAuthorizationFilter() }
                });

                // app.ResetDatabaseAsync(); // ( check 'Options/ResetDatabase' )
                app.UseStaticFiles(new StaticFileOptions
                {
                    FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "Content")),
                    RequestPath = "/Content"
                });

                // - Run ------------------------------------------------------------------
                app.Run();
            }
            catch (Exception ex)
            {
                // Log any unhandled exception
                Log.Fatal(ex, "A fatal exception has caused the application to stop.");
            }
            finally
            {
                // Ensure to flush and stop Serilog properly
                Log.CloseAndFlush();
            }
        }
    }
}