using System.Text.Json.Serialization;

namespace MB.Application.Models;

public class BaseResponse
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string[]? ValidationErrors { get; set; } = null;
}