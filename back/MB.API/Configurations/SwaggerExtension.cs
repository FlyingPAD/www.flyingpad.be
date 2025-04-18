﻿using Microsoft.OpenApi.Models;

namespace MB.API.Configurations
{
    public static class SwaggerExtensions
    {
        public static IServiceCollection AddCustomSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("system", new OpenApiInfo { Version = "v1", Title = "FlyingPAD - System" });
                c.SwaggerDoc("features", new OpenApiInfo { Version = "v1", Title = "FlyingPAD - Features" });
                c.SwaggerDoc("extensions", new OpenApiInfo { Version = "v1", Title = "FlyingPAD - Extensions" });
                c.SwaggerDoc("relations", new OpenApiInfo { Version = "v1", Title = "FlyingPAD - Relations" });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: 'Authorization: Bearer {token}'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,
                        },
                        new List<string>()
                    }
                });

                c.OperationFilter<CustomProducesResponseOperationFilter>();

                var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = System.IO.Path.Combine(AppContext.BaseDirectory, xmlFile);
                if (System.IO.File.Exists(xmlPath))
                {
                    c.IncludeXmlComments(xmlPath);
                }
            });

            return services;
        }

        public static IApplicationBuilder UseCustomSwagger(this IApplicationBuilder app)
        {
            if (app.ApplicationServices.GetRequiredService<IWebHostEnvironment>().IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/system/swagger.json", "FlyingPAD - System");
                    c.SwaggerEndpoint("/swagger/features/swagger.json", "FlyingPAD - Features");
                    c.SwaggerEndpoint("/swagger/extensions/swagger.json", "FlyingPAD - Extensions");
                    c.SwaggerEndpoint("/swagger/relations/swagger.json", "FlyingPAD - Relations");
                });
            }

            return app;
        }
    }
}