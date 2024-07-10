namespace MB.Application
{
    public enum ResponseStatus
    {
        // Success
        Success = 200,

        // Client Errors
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        MethodNotAllowed = 405,
        Conflict = 409,
        UnprocessableEntity = 422,
        TooManyRequests = 429,

        // Server Errors
        InternalServerError = 500,
        NotImplemented = 501,
        ServiceUnavailable = 503,

        // Fun
        ImATeapot = 418, // RFC 2324

        // Additional CRUD-related statuses
        Created = 201, // Resource created successfully
        Accepted = 202, // Request accepted for processing
        NoContent = 204, // No content to return for the request
        ResetContent = 205, // Reset the document view which caused the request
        PartialContent = 206, // Partial content returned
    }
}