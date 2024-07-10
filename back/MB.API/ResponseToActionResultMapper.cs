using MB.Application;
using Microsoft.AspNetCore.Mvc;

namespace MB.API
{
    public static class ResponseToActionResultMapper
    {
        public static IActionResult Map(BaseResponse response)
        {
            return response.StatusCode switch
            {
                ResponseStatus.Success => new OkObjectResult(response),
                ResponseStatus.Created => new CreatedResult(string.Empty, response),
                ResponseStatus.Accepted => new AcceptedResult(),
                ResponseStatus.NoContent => new NoContentResult(),
                ResponseStatus.ResetContent => new StatusCodeResult((int)ResponseStatus.ResetContent),
                ResponseStatus.PartialContent => new StatusCodeResult((int)ResponseStatus.PartialContent),
                ResponseStatus.BadRequest => new BadRequestObjectResult(response),
                ResponseStatus.Unauthorized => new UnauthorizedObjectResult(response),
                ResponseStatus.Forbidden => new ForbidResult(),
                ResponseStatus.NotFound => new NotFoundObjectResult(response),
                ResponseStatus.MethodNotAllowed => new StatusCodeResult((int)ResponseStatus.MethodNotAllowed),
                ResponseStatus.Conflict => new ConflictObjectResult(response),
                ResponseStatus.UnprocessableEntity => new UnprocessableEntityObjectResult(response),
                ResponseStatus.TooManyRequests => new StatusCodeResult((int)ResponseStatus.TooManyRequests),
                ResponseStatus.InternalServerError => new ObjectResult(response) { StatusCode = (int)ResponseStatus.InternalServerError },
                ResponseStatus.NotImplemented => new StatusCodeResult((int)ResponseStatus.NotImplemented),
                ResponseStatus.ServiceUnavailable => new StatusCodeResult((int)ResponseStatus.ServiceUnavailable),
                ResponseStatus.ImATeapot => new StatusCodeResult((int)ResponseStatus.ImATeapot),
                _ => new StatusCodeResult((int)ResponseStatus.InternalServerError)
            };
        }
    }
}