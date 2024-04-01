using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Tags.Queries.CountTags;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Test.Features.Tags.Queries
{
    public class CountTagsQueryTest
    {
        private Mock<IBaseRepository<Tag>> _tagRepositoryMock;
        private CountTagsQueryHandler _handler;

        public CountTagsQueryTest()
        {
            _tagRepositoryMock = new Mock<IBaseRepository<Tag>>();
            _handler = new CountTagsQueryHandler(_tagRepositoryMock.Object);
        }

        [Fact]
        public async System.Threading.Tasks.Task Handle_Should_Return_Correct_Count() 
        {
            // Arrange

            var expectedCount = 42;

            _tagRepositoryMock.Setup(repo => repo.CountAsync()).ReturnsAsync(expectedCount);

            var request = new CountTagsQuery();

            // Act

            var result = await _handler.Handle(request, new CancellationToken());

            // Assert

            Assert.True(result.Success);
            Assert.Equal($"Total Tags : {expectedCount}", result.Message);
            Assert.Equal(expectedCount, result.TagsCount);

            _tagRepositoryMock.Verify(repo => repo.CountAsync(), Times.Once);
        }
    }
}