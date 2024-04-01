using MB.Application.Contracts.Persistence;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Artists.Commands.DeleteArtist;
using MB.Application.Features.Task.Commands.DeleteTask;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Test.Features.Artists.Commands
{
    public class DeleteArtistCommandHandlerTest
    {
        private readonly Mock<IBaseRepository<Artist>> _artistRepoMock;
        private readonly Mock<IRelationRepository> _relationRepoMock;
        private readonly DeleteArtistCommandHandler _handler;

        public DeleteArtistCommandHandlerTest()
        {
            _artistRepoMock = new Mock<IBaseRepository<Artist>>();
            _relationRepoMock = new Mock<IRelationRepository>();
            var validator = new DeleteArtistCommandValidator(); // Assuming the validator is correctly initialized

            _handler = new DeleteArtistCommandHandler(_artistRepoMock.Object, _relationRepoMock.Object, validator);
        }

        [Fact]
        public async System.Threading.Tasks.Task Handle_Should_Return_Error_When_Artist_Is_Not_Found()
        {
            var artistId = Guid.NewGuid();
            var request = new DeleteArtistCommand { BusinessId = artistId };

            _artistRepoMock.Setup(repo => repo.GetByBusinessIdAsync(artistId))
                .ReturnsAsync((Artist)null);

            var response = await _handler.Handle(request, new System.Threading.CancellationToken());

            Assert.False(response.Success);
            Assert.Contains($"Artist with ID {artistId} was not found.", response.ValidationErrors);
            _artistRepoMock.Verify(repo => repo.DeleteAsync(It.IsAny<Artist>()), Times.Never);
            _relationRepoMock.Verify(repo => repo.DeleteRelationsByArtistIdAsync(It.IsAny<int>()), Times.Never);
        }

        [Fact]
        public async System.Threading.Tasks.Task Handle_Should_Call_DeleteRelations_And_DeleteAsync_When_Artist_Is_Found()
        {
            var artistId = Guid.NewGuid();
            var request = new DeleteArtistCommand { BusinessId = artistId };
            var artist = new Artist { EntityId = 1, BusinessId = artistId };

            _artistRepoMock.Setup(repo => repo.GetByBusinessIdAsync(artistId)).ReturnsAsync(artist);

            await _handler.Handle(request, new System.Threading.CancellationToken());

            _relationRepoMock.Verify(repo => repo.DeleteRelationsByArtistIdAsync(artist.EntityId), Times.Once);
            _artistRepoMock.Verify(repo => repo.DeleteAsync(artist), Times.Once);
        }
    }
}
