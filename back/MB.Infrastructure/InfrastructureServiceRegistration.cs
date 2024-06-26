﻿using Hangfire;
using MB.Application.Contracts;
using MB.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MB.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<IEMailService, EMailService>();
            services.AddScoped<IGraphAPIService, GraphAPIService>();
            services.AddSingleton<IAuthentificationService, AuthenticationService>();

            services.AddHttpClient();

            services.AddHangfire(config => config
                .UseSqlServerStorage(configuration.GetConnectionString("DBHangFire")));
            services.AddHangfireServer();

            return services;
        }
    }
}