using MB.Application.Features.Artists.Queries.CountArtists;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Tests.Features.Artists.Queries
{
    public class CountArtistsQueryHandlerTests
    {
        private readonly Mock<IBaseRepository<Artist>> _artistRepositoryMock;
        private readonly CountArtistsQueryHandler _handler;

        public CountArtistsQueryHandlerTests()
        {
            _artistRepositoryMock = new Mock<IBaseRepository<Artist>>();
            _handler = new CountArtistsQueryHandler(_artistRepositoryMock.Object);
        }

        [Fact]
        public async System.Threading.Tasks.Task Handle_ShouldReturnCorrectCount()
        {
            _artistRepositoryMock.Setup(repo => repo.CountAsync()).ReturnsAsync(10);

            var result = await _handler.Handle(new CountArtistsQuery(), new CancellationToken());

            Assert.True(result.Success);
            Assert.Equal(10, result.TotalArtists);
        }

        [Fact]
        public async System.Threading.Tasks.Task Handle_ShouldReturnZeroWhenNoArtists()
        {
            _artistRepositoryMock.Setup(repo => repo.CountAsync()).ReturnsAsync(0);

            var result = await _handler.Handle(new CountArtistsQuery(), new CancellationToken());

            Assert.True(result.Success);
            Assert.Equal(0, result.TotalArtists);
        }

        [Fact]
        public async System.Threading.Tasks.Task Handle_ShouldThrowExceptionOnFailure()
        {
            _artistRepositoryMock.Setup(repo => repo.CountAsync()).ThrowsAsync(new Exception());

            await Assert.ThrowsAsync<Exception>(() => _handler.Handle(new CountArtistsQuery(), new CancellationToken()));
        }
    }
}