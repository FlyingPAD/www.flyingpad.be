using MB.Application.Features.Artists.Commands.DeleteArtist;
using MB.Application.Interfaces.Persistence;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Tests.Features.Artists.Commands;

public class DeleteArtistCommandHandlerTest
{
    private readonly Mock<IArtistRepository> _artistRepoMock;
    private readonly DeleteArtistCommandHandler _handler;

    public DeleteArtistCommandHandlerTest()
    {
        _artistRepoMock = new Mock<IArtistRepository>();
        var validator = new DeleteArtistCommandValidator();

        _handler = new DeleteArtistCommandHandler(_artistRepoMock.Object, validator);
    }

    [Fact]
    public async System.Threading.Tasks.Task Handle_Should_Return_Error_When_Artist_Is_Not_Found()
    {
        var artistId = Guid.NewGuid();
        var request = new DeleteArtistCommand { BusinessId = artistId };

        _artistRepoMock.Setup(repo => repo.GetByBusinessIdAsync(artistId))
            .ReturnsAsync((Artist?)null);

        var response = await _handler.Handle(request, new CancellationToken());

        Assert.False(response.Success);
        Assert.Contains($"Artist with ID {artistId} was not found.", response.ValidationErrors);
        _artistRepoMock.Verify(repo => repo.DeleteAsync(It.IsAny<Artist>()), Times.Never);
        _artistRepoMock.Verify(repo => repo.DeleteStyles(It.IsAny<int>()), Times.Never);
    }

    [Fact]
    public async System.Threading.Tasks.Task Handle_Should_Call_DeleteStyles_And_DeleteAsync_When_Artist_Is_Found()
    {
        var artistId = Guid.NewGuid();
        var request = new DeleteArtistCommand { BusinessId = artistId };
        var artist = new Artist { EntityId = 1, BusinessId = artistId };

        _artistRepoMock.Setup(repo => repo.GetByBusinessIdAsync(artistId)).ReturnsAsync(artist);

        await _handler.Handle(request, new CancellationToken());

        _artistRepoMock.Verify(repo => repo.DeleteStyles(artist.EntityId), Times.Once);
        _artistRepoMock.Verify(repo => repo.DeleteAsync(artist), Times.Once);
    }
}