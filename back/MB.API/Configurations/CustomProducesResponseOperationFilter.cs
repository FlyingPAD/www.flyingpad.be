using MB.Application;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace MB.API.Configurations
{
    public class CustomProducesResponseOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (!operation.Responses.ContainsKey("200"))
            {
                operation.Responses.Add("200", new OpenApiResponse { Description = "OK" });
            }

            if (!operation.Responses.ContainsKey("400"))
            {
                operation.Responses.Add("400", new OpenApiResponse
                {
                    Description = "Bad Request",
                    Content = new Dictionary<string, OpenApiMediaType>
                    {
                        { "application/json", new OpenApiMediaType
                            {
                                Schema = context.SchemaGenerator.GenerateSchema(typeof(BaseResponse), context.SchemaRepository)
                            }
                        }
                    }
                });
            }

            if (!operation.Responses.ContainsKey("404"))
            {
                operation.Responses.Add("404", new OpenApiResponse
                {
                    Description = "Not Found",
                    Content = new Dictionary<string, OpenApiMediaType>
                    {
                        { "application/json", new OpenApiMediaType
                            {
                                Schema = context.SchemaGenerator.GenerateSchema(typeof(BaseResponse), context.SchemaRepository)
                            }
                        }
                    }
                });
            }
            if (!operation.Responses.ContainsKey("500"))
            {
                operation.Responses.Add("500", new OpenApiResponse
                {
                    Description = "Internal Server Error",
                    Content = new Dictionary<string, OpenApiMediaType>
                    {
                        { "application/json", new OpenApiMediaType
                            {
                                Schema = context.SchemaGenerator.GenerateSchema(typeof(BaseResponse), context.SchemaRepository)
                            }
                        }
                    }
                });
            }
        }
    }
}