namespace MB.Application;

public class BaseResponse
{
    public bool Success { get; set; }
    public ResponseStatus StatusCode { get; set; }
    public string Message { get; set; } = string.Empty;
    public List<string> ValidationErrors { get; set; } = [];
}