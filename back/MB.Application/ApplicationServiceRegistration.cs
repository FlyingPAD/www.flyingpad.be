using FluentValidation;
using MB.Application.Interfaces.Services;
using MB.Application.Services;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MB.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(configuration => configuration.AddMaps(Assembly.GetExecutingAssembly()));
        services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

        services.AddScoped<ITokenManager, TokenManager>();

        services.AddScoped<IEmailTokenCleanupService, EmailTokenCleanupService>();
        services.AddScoped<IDailyReportService, DailyReportService>();
        services.AddScoped<ISeasonService, SeasonService>();

        return services;
    }
}