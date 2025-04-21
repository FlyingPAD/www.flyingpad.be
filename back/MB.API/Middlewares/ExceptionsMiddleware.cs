using FluentValidation;
using MB.Application;
using MB.Application.Exceptions;
using System.Text.Json;

namespace MB.API.Middlewares;

public class ExceptionsMiddleware(RequestDelegate next)
{
    private readonly RequestDelegate _next = next;

    private static readonly JsonSerializerOptions _jsonSerializerOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = false
    };

    private readonly bool _isDevelopment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";

    public async Task Invoke(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (ValidationException exception)
        {
            await HandleValidationExceptionAsync(httpContext, exception);
        }
        catch (InvalidCredentialException exception)
        {
            await HandleInvalidCredentialExceptionAsync(httpContext, exception);
        }
        catch (NotFoundException exception)
        {
            await HandleNotFoundExceptionAsync(httpContext, exception.Message);
        }
        catch (Exception exception)
        {
            await HandleExceptionAsync(httpContext, exception);
        }

        if (!httpContext.Response.HasStarted)
        {
            await HandleStatusCodesAsync(httpContext);
        }
    }

    private static async Task HandleValidationExceptionAsync(HttpContext context, ValidationException exception)
    {
        var validationErrors = exception.Errors
            .Select(error => error.ErrorMessage)
            .ToArray();

        var response = new BaseResponse
        {
            Success = false,
            Message = "Bad Request.",
            ValidationErrors = validationErrors
        };

        context.Response.StatusCode = StatusCodes.Status400BadRequest;
        await WriteJsonResponseAsync(context, response);
    }

    private static async Task HandleInvalidCredentialExceptionAsync(HttpContext context, InvalidCredentialException exception)
    {
        var response = new BaseResponse
        {
            Success = false,
            Message = exception.Message
        };

        context.Response.StatusCode = StatusCodes.Status400BadRequest;
        await WriteJsonResponseAsync(context, response);
    }

    private static async Task HandleNotFoundExceptionAsync(HttpContext context, string? message = null)
    {
        var response = new BaseResponse
        {
            Success = false,
            Message = message ?? "Not found."
        };

        context.Response.StatusCode = StatusCodes.Status404NotFound;
        await WriteJsonResponseAsync(context, response);
    }

    private async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        var response = new BaseResponse
        {
            Success = false,
            Message = _isDevelopment
                ? exception.StackTrace ?? "Internal Server Error."
                : "Internal Server Error."
        };

        context.Response.StatusCode = StatusCodes.Status500InternalServerError;
        await WriteJsonResponseAsync(context, response);
    }

    private static async Task HandleStatusCodesAsync(HttpContext context)
    {
        if (context.Response.StatusCode == StatusCodes.Status404NotFound)
        {
            await HandleNotFoundExceptionAsync(context);
        }
        else if (context.Response.StatusCode == StatusCodes.Status200OK && context.Request.Method == HttpMethods.Post)
        {
            context.Response.StatusCode = StatusCodes.Status201Created;
        }
    }

    private static async Task WriteJsonResponseAsync(HttpContext context, BaseResponse response)
    {
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(JsonSerializer.Serialize(response, _jsonSerializerOptions));
    }
}