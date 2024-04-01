using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Artists.Queries.CountArtists;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Test.Features.Artists.Queries
{
    public class CountArtistsQueryTest
    {
        private Mock<IBaseRepository<Artist>> _artistRepositoryMock;
        private CountArtistsQueryHandler _handler;

        public CountArtistsQueryTest()
        {
            _artistRepositoryMock = new Mock<IBaseRepository<Artist>>();
            _handler = new CountArtistsQueryHandler(_artistRepositoryMock.Object);
        }

        [Fact]
        public async System.Threading.Tasks.Task Handle_Should_Return_Correct_Count() 
        {
            // Arrange

            var expectedCount = 42;

            _artistRepositoryMock.Setup(repo => repo.CountAsync()).ReturnsAsync(expectedCount);

            var request = new CountArtistsQuery();

            // Act

            var result = await _handler.Handle(request, new CancellationToken());

            // Assert

            Assert.True(result.Success);
            Assert.Equal($"Total Artists : {expectedCount}", result.Message);
            Assert.Equal(expectedCount, result.ArtistsCount);

            _artistRepositoryMock.Verify(repo => repo.CountAsync(), Times.Once);
        }
    }
}