namespace MB.Application.Models;

public class BaseResponse
{
    public bool Success { get; set; }
    public ResponseStatusEnumeration StatusCode { get; set; }
    public string Message { get; set; } = string.Empty;
    public List<string> ValidationErrors { get; set; } = [];
}