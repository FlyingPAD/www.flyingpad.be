using MB.API.Models;
using MB.Application.Exceptions;
using System.Text.Json;

namespace MB.API.Handlers
{
    public class ExceptionHandler(RequestDelegate next, ILogger<ExceptionHandler> logger)
    {
        private readonly RequestDelegate _next = next;
        private readonly ILogger _logger = logger;

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next.Invoke(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                _logger.LogError(ex.StackTrace);

                if (ex.InnerException != null)
                {
                    _logger.LogError(ex.InnerException.Message);
                    _logger.LogError(ex.InnerException.StackTrace);
                }

                await HandleExceptionAsync(ex, httpContext);
            }
        }

        private static async Task HandleExceptionAsync(Exception exception, HttpContext httpContext)
        {
            var statusCode = GetStatusCode(exception);
            var errorResponse = new ApiErrorResponse
            {
                Message = exception.Message
            };

            if (exception is ModelValidationException modelValidationException)
            {
                errorResponse.ValidationErrors = GetModelValidationErrorsFromContext(httpContext);
                errorResponse.Message = "Validation failed"; // Ou un message plus spécifique ou dynamique
            }

            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = statusCode;

            var responseString = JsonSerializer.Serialize(errorResponse);

            await httpContext.Response.WriteAsync(responseString);
        }

        private static int GetStatusCode(Exception ex) => ex switch
        {
            ModelValidationException => StatusCodes.Status400BadRequest,
            NotFoundException => StatusCodes.Status404NotFound,
            _ => StatusCodes.Status500InternalServerError
        };

        private static List<ModelValidationError> GetModelValidationErrorsFromContext(HttpContext httpContext)
        {
            var modelValidationErrors = new List<ModelValidationError>();

            var modelState = httpContext.Features.Get<ModelStateFeature>()?.ModelState;

            if (modelState != null)
            {
                foreach (var modelStateEntry in modelState)
                {
                    if (modelStateEntry.Value?.Errors.Count > 0)
                    {
                        foreach (var modelError in modelStateEntry.Value.Errors)
                        {
                            var error = new ModelValidationError
                            {
                                Name = modelStateEntry.Key,
                                Description = modelError.ErrorMessage
                            };
                            modelValidationErrors.Add(error);
                        }
                    }
                }
            }

            return modelValidationErrors;
        }

    }
}