namespace MB.Application.Responses
{
    public class BaseResponse
    {
        public bool Success { get; set; } = false;
        public string Message { get; set; } = string.Empty;
        public List<string> ValidationErrors { get; set; } = [];
    }
}