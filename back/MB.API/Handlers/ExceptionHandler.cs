using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Text.Json;

namespace MB.API.Handlers;

public class ExceptionHandler(RequestDelegate next)
{
    private readonly RequestDelegate _next = next;
    private static readonly JsonSerializerOptions _jsonSerializerOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    public async Task Invoke(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "An unhandled exception has been captured");
            await HandleExceptionAsync(httpContext);
        }
    }

    private static async Task HandleExceptionAsync(HttpContext context)
    {
        context.Response.ContentType = "application/json";
        var problemDetails = new ProblemDetails
        {
            Status = StatusCodes.Status500InternalServerError,
            Title = "An error occurred",
            Detail = "An unexpected error occurred. Please try again later.",
            Instance = context.Request.Path
        };

        context.Response.StatusCode = problemDetails.Status.Value;

        try
        {
            var responseString = JsonSerializer.Serialize(problemDetails, _jsonSerializerOptions);
            await context.Response.WriteAsync(responseString);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "An error occurred while serializing the error response");
            await context.Response.WriteAsync("An error occurred");
        }
    }
}