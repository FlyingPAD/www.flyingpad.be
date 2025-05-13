using MediatR;

namespace MB.Application.Features.Leagues.Queries.GetLeagueByName;

public class GetLeagueByNameQuery : IRequest<GetLeagueByNameQueryResponse>
{
    public string Name { get; set; } = string.Empty;
}