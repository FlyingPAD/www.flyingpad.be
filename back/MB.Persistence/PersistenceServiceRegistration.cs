using MB.Application.Interfaces.Persistence;
using MB.Application.Interfaces.Persistence.Definitions;
using MB.Application.Interfaces.Persistence.Read;
using MB.Application.Interfaces.Persistence.Write;
using MB.Persistence.Contexts;
using MB.Persistence.Repositories;
using MB.Persistence.Repositories.Definitions;
using MB.Persistence.Repositories.Read;
using MB.Persistence.Repositories.Write;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace MB.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connexionString = configuration.GetConnectionString("DB");

        // Old Context ( Obsolete, but still used by existing repositories )
        services.AddDbContext<Context>(options => options.UseSqlServer(connexionString)
            .EnableSensitiveDataLogging()      
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)          
            .LogTo(Console.WriteLine, LogLevel.Information)
        );

        // Old Reposiroies ( Obsolete, but still used by existing services )
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IAchievementDefinitionsRepository, AchievementDefinitionsRepository>();
        services.AddScoped<IArtistRepository, ArtistRepository>();
        services.AddScoped<IAuthRepository, AuthRepository>();
        services.AddScoped<IEmailVerificationTokenRepository, EmailVerificationTokenRepository>();
        services.AddScoped<IFranchiseRepository, FranchiseRepository>();
        services.AddScoped<ILeagueDefinitionsRepository, LeagueDefinitionsRepository>();
        services.AddScoped<ILevelDefinitionRepository, LevelDefinitionRepository>();
        services.AddScoped<ILinkCategoryRepository, LinkCategoryRepository>();
        services.AddScoped<ILinkRepository, LinkRepository>();
        services.AddScoped<IMediaRepository, MediaRepository>();
        services.AddScoped<IModelRepository, ModelRepository>();
        services.AddScoped<IMoodRepository, MoodRepository>();
        services.AddScoped<ISeasonRepository, SeasonRepository>();
        services.AddScoped<IStyleRepository, StyleRepository>();
        services.AddScoped<ITagRepository, TagRepository>();
        services.AddScoped<ITaskCategoryRepository, TaskCategoryRepository>();
        services.AddScoped<ITaskRepository, TaskRepository>();
        services.AddScoped<IUserAchievementRepository, UserAchievementRepository>();
        services.AddScoped<IUserRepository, UserRepository>();

        // 1) WriteContext
        services.AddDbContext<WriteContext>(options => options.UseSqlServer(connexionString)
            .EnableSensitiveDataLogging()
            .UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll)
            .LogTo(Console.WriteLine, LogLevel.Information)
        );

        services.AddScoped<IWriteArtistRepository, WriteArtistRepository>();

        // 2) ReadContext
        services.AddDbContext<ReadContext>(options => options.UseSqlServer(connexionString)
            .EnableSensitiveDataLogging()
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
            .LogTo(Console.WriteLine, LogLevel.Information)
        );

        services.AddScoped<IReadArtistRepository, ReadArtistRepository>();

        return services;
    }
}