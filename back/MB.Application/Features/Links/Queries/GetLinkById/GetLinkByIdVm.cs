﻿namespace MB.Application.Features.Links.Queries.GetLinkById;

public class GetLinkByIdVm
{
    public Guid BusinessId { get; set; } = Guid.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public DateTime Created { get; set; } = DateTime.MinValue;
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime Modified { get; set; } = DateTime.MinValue;
    public string ModifiedBy { get; set; } = string.Empty;
}