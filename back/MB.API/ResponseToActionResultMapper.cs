using MB.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace MB.API
{
    public static class ResponseToActionResultMapper
    {
        public static IActionResult Map(BaseResponse response)
        {
            return response.StatusCode switch
            {
                ResponseStatusEnumeration.Success => new OkObjectResult(response),
                ResponseStatusEnumeration.Created => new CreatedResult(string.Empty, response),
                ResponseStatusEnumeration.Accepted => new AcceptedResult(),
                ResponseStatusEnumeration.NoContent => new NoContentResult(),
                ResponseStatusEnumeration.ResetContent => new StatusCodeResult((int)ResponseStatusEnumeration.ResetContent),
                ResponseStatusEnumeration.PartialContent => new StatusCodeResult((int)ResponseStatusEnumeration.PartialContent),
                ResponseStatusEnumeration.BadRequest => new BadRequestObjectResult(response),
                ResponseStatusEnumeration.Unauthorized => new UnauthorizedObjectResult(response),
                ResponseStatusEnumeration.Forbidden => new ForbidResult(),
                ResponseStatusEnumeration.NotFound => new NotFoundObjectResult(response),
                ResponseStatusEnumeration.MethodNotAllowed => new StatusCodeResult((int)ResponseStatusEnumeration.MethodNotAllowed),
                ResponseStatusEnumeration.Conflict => new ConflictObjectResult(response),
                ResponseStatusEnumeration.UnprocessableEntity => new UnprocessableEntityObjectResult(response),
                ResponseStatusEnumeration.TooManyRequests => new StatusCodeResult((int)ResponseStatusEnumeration.TooManyRequests),
                ResponseStatusEnumeration.InternalServerError => new ObjectResult(response) { StatusCode = (int)ResponseStatusEnumeration.InternalServerError },
                ResponseStatusEnumeration.NotImplemented => new StatusCodeResult((int)ResponseStatusEnumeration.NotImplemented),
                ResponseStatusEnumeration.ServiceUnavailable => new StatusCodeResult((int)ResponseStatusEnumeration.ServiceUnavailable),
                ResponseStatusEnumeration.ImATeapot => new StatusCodeResult((int)ResponseStatusEnumeration.ImATeapot),
                _ => new StatusCodeResult((int)ResponseStatusEnumeration.InternalServerError)
            };
        }
    }
}