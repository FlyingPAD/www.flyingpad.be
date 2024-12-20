﻿using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Artists.Commands.UpdateArtist;

public class UpdateArtistCommand : IRequest<BaseResponse>
{
    public Guid ArtistId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<Guid> StyleIds { get; set; } = [];
}