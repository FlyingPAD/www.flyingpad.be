﻿namespace MB.Application.Features.Moods.Queries.GetMoodsByTag;

public class GetMoodsByTagQueryDto
{
    public Guid BusinessId { get; set; }
    public int Type { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Extension { get; set; } = string.Empty;
    public int Score { get; set; }
}