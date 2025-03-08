using MB.Application.Exceptions;
using MB.Application.Features.Artists.Commands.CreateArtist;
using MB.Application.Interfaces.Persistence;
using MB.Domain.ArtistAggregate;
using Moq;
using Xunit;

namespace MB.Application.Tests.Features.Artists.Commands
{
    public class CreateArtistCommandHandlerTests
    {
        private readonly Mock<IArtistRepository> _artistRepositoryMock;
        private readonly Mock<IStyleRepository> _styleRepositoryMock;
        private readonly CreateArtistCommandHandler _handler;

        public CreateArtistCommandHandlerTests()
        {
            _artistRepositoryMock = new Mock<IArtistRepository>();
            _styleRepositoryMock = new Mock<IStyleRepository>();
            _handler = new CreateArtistCommandHandler(_artistRepositoryMock.Object, _styleRepositoryMock.Object);
        }

        [Fact]
        public async System.Threading.Tasks.Task Handle_ShouldCreateArtistSuccessfully()
        {
            // Arrange
            var artist = new Artist { EntityId = 1, BusinessId = Guid.NewGuid() };
            _artistRepositoryMock.Setup(repo => repo.CreateAsync(It.IsAny<Artist>())).ReturnsAsync(artist);
            _styleRepositoryMock.Setup(repo => repo.GetPrimaryIdsByBusinessIdsAsync(It.IsAny<List<Guid>>()))
                                .ReturnsAsync([1, 2]);
            _artistRepositoryMock.Setup(repo => repo.AddArtistStylesAsync(It.IsAny<int>(), It.IsAny<List<int>>()))
                                 .Returns(System.Threading.Tasks.Task.CompletedTask);

            var command = new CreateArtistCommand { Name = "Test Artist", Description = "Description", StyleIds = [Guid.NewGuid(), Guid.NewGuid()] };

            // Act
            var result = await _handler.Handle(command, new CancellationToken());

            // Assert
            Assert.True(result.Success);
            Assert.Equal("Creation successful.", result.Message);
            Assert.Equal(artist.BusinessId, result.ArtistId);
        }

        [Fact]
        public async System.Threading.Tasks.Task Handle_ShouldThrowNotFoundExceptionWhenStyleNotFound()
        {
            // Arrange
            _artistRepositoryMock.Setup(repo => repo.CreateAsync(It.IsAny<Artist>())).ReturnsAsync(new Artist());
            _styleRepositoryMock.Setup(repo => repo.GetPrimaryIdsByBusinessIdsAsync(It.IsAny<List<Guid>>()))
                                .ReturnsAsync([1]); // Fewer styles found than requested

            var command = new CreateArtistCommand { Name = "Test Artist", Description = "Description", StyleIds = [Guid.NewGuid(), Guid.NewGuid()] };

            // Act & Assert
            await Assert.ThrowsAsync<NotFoundException>(() => _handler.Handle(command, new CancellationToken()));
        }

        [Fact]
        public async System.Threading.Tasks.Task Handle_ShouldThrowExceptionWhenAddingStylesFails()
        {
            // Arrange
            var artist = new Artist { EntityId = 1 };
            _artistRepositoryMock.Setup(repo => repo.CreateAsync(It.IsAny<Artist>())).ReturnsAsync(artist);
            _styleRepositoryMock.Setup(repo => repo.GetPrimaryIdsByBusinessIdsAsync(It.IsAny<List<Guid>>()))
                                .ReturnsAsync([1, 2]);
            _artistRepositoryMock.Setup(repo => repo.AddArtistStylesAsync(It.IsAny<int>(), It.IsAny<List<int>>()))
                                 .ThrowsAsync(new Exception("Failed to add styles"));

            var command = new CreateArtistCommand { Name = "Test Artist", Description = "Description", StyleIds = [Guid.NewGuid(), Guid.NewGuid()] };

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(() => _handler.Handle(command, new CancellationToken()));
        }
    }
}