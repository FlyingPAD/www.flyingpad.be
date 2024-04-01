namespace MB.API.Models
{
    public class ApiErrorResponse
    {
        public string? Message { get; set; }
        public List<ModelValidationError>? ValidationErrors { get; set; }
    }
}
