using Microsoft.OpenApi.Models;

namespace MB.API;

public static class Swagger
{
    /// <summary>
    /// Configures Swagger services to generate API documentation.
    /// initializes the Swagger generator and sets up JWT Bearer Token authentication for secure endpoints.
    /// </summary>
    /// <param name="services">The service collection to which the Swagger services will be added.</param>
    public static void Add(IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            // Create Swagger documents for "system" and "features" groups.

            c.SwaggerDoc("system", new OpenApiInfo { Version = "v1", Title = "FlyingPAD - System" });
            c.SwaggerDoc("features", new OpenApiInfo { Version = "v1", Title = "FlyingPAD - Features" });
            c.SwaggerDoc("extensions", new OpenApiInfo { Version = "v1", Title = "FlyingPAD - Extensions" });
            c.SwaggerDoc("relations", new OpenApiInfo { Version = "v1", Title = "FlyingPAD - Relations" });

            // Define the JWT Bearer Token authentication scheme for Swagger.
            // This setup informs Swagger how to send the JWT in requests, expecting an 'Authorization' header formatted as 'Bearer {token}'.

            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Description = "JWT Authorization header using the Bearer scheme. Example: 'Authorization: Bearer {token}'",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.Http,
                Scheme = "bearer" // Note: The 'bearer' keyword must be lowercase.
            });

            // Apply the JWT Bearer Token security definition to all API operations.
            // This setup means the Swagger UI will provide an input for the token, which is then used for all protected API calls.

            c.AddSecurityRequirement(new OpenApiSecurityRequirement()
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            // Reference the previously defined 'Bearer' security scheme.

                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        },
                        // OAuth2 is indicated here but used to represent the Bearer token scheme for Swagger UI.

                        Scheme = "oauth2",
                        Name = "Bearer",
                        In = ParameterLocation.Header,
                    },

                    new List<string>() // An empty list, as JWT Bearer tokens do not use scopes in this setup.
                    // A list of strings normally contains the required scopes; however, for JWT Bearer tokens, scopes are not specified here.
                }
            });
        });
    }

    public static void Use(WebApplication app)
    {
        // Set up Swagger and Swagger UI only in the development environment.

        if (app.Environment.IsDevelopment())
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
    }
}