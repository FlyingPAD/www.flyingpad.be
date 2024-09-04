using FluentValidation;
using MB.Application.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace MB.API.Middlewares;

public class ExceptionsMiddleware(RequestDelegate next)
{
    private static readonly JsonSerializerOptions _jsonSerializerOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = false
    };

    private readonly bool _isDevelopment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";

    private const string ResourceNotFoundTitle = "Resource not found";
    private const string ResourceNotFoundDetail = "The requested resource was not found on this server.";
    private const string ValidationFailedTitle = "Validation Failed";
    private const string ValidationFailedDetail = "One or more validation errors occurred.";
    private const string GenericErrorTitle = "An error occurred";
    private const string GenericErrorDetail = "An unexpected error occurred. Please try again later.";

    public async Task Invoke(HttpContext httpContext)
    {
        try
        {
            await next(httpContext);
        }
        catch (ValidationException exception)
        {
            await HandleValidationExceptionAsync(httpContext, exception);
            return;
        }
        catch (NotFoundException exception)
        {
            await HandleNotFoundExceptionAsync(httpContext, exception.Message);
            return;
        }
        catch (Exception exception)
        {
            await HandleExceptionAsync(httpContext, exception);
            return;
        }

        if (!httpContext.Response.HasStarted)
        {
            await HandleStatusCodesAsync(httpContext);
        }
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

    private static async Task HandleNotFoundExceptionAsync(HttpContext context, string? message = null)
    {
        var detailMessage = message ?? ResourceNotFoundDetail;
        var problemDetails = CreateProblemDetails(context, StatusCodes.Status404NotFound, ResourceNotFoundTitle, detailMessage);
        await WriteJsonResponseAsync(context, problemDetails);
    }

    private static async Task HandleValidationExceptionAsync(HttpContext context, ValidationException exception)
    {
        var validationErrors = exception.Errors
            .GroupBy(validationFailure => validationFailure.PropertyName)
            .ToDictionary(
                group => group.Key,
                group => group.Select(validationFailure => validationFailure.ErrorMessage).ToArray()
            );

        var problemDetails = new ValidationProblemDetails
        {
            Status = StatusCodes.Status400BadRequest,
            Title = ValidationFailedTitle,
            Detail = ValidationFailedDetail,
            Instance = context.Request.Path,
            Errors = validationErrors
        };

        await WriteJsonResponseAsync(context, problemDetails);
    }

    private async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        var problemDetails = CreateProblemDetails(context, StatusCodes.Status500InternalServerError, GenericErrorTitle, GenericErrorDetail);

        if (_isDevelopment)
        {
            problemDetails.Detail = exception.StackTrace;
        }
        else
        {
            problemDetails.Detail = exception.Message;
        }

        await WriteJsonResponseAsync(context, problemDetails);
    }

    private static async Task WriteJsonResponseAsync(HttpContext context, object problemDetails)
    {
        context.Response.ContentType = "application/json";
        await context.Response.WriteAsync(JsonSerializer.Serialize(problemDetails, _jsonSerializerOptions));
    }

    private static ProblemDetails CreateProblemDetails(HttpContext context, int statusCode, string title, string detail)
    {
        return new ProblemDetails
        {
            Status = statusCode,
            Title = title,
            Detail = detail,
            Instance = context.Request.Path
        };
    }
}