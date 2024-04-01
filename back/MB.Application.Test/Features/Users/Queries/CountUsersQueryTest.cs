using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Users.Queries.CountUsers;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Test.Features.Users.Queries
{
    public class CountUsersQueryTest
    {
        private Mock<IBaseRepository<User>> _userRepositoryMock;
        private CountUsersQueryHandler _handler;

        public CountUsersQueryTest()
        {
            _userRepositoryMock = new Mock<IBaseRepository<User>>();
            _handler = new CountUsersQueryHandler(_userRepositoryMock.Object);
        }

        [Fact]
        public async System.Threading.Tasks.Task Handle_Should_Return_Correct_Count() 
        {
            // Arrange

            var expectedCount = 42;

            _userRepositoryMock.Setup(repo => repo.CountAsync()).ReturnsAsync(expectedCount);

            var request = new CountUsersQuery();

            // Act

            var result = await _handler.Handle(request, new CancellationToken());

            // Assert

            Assert.True(result.Success);
            Assert.Equal($"Total Users : {expectedCount}", result.Message);
            Assert.Equal(expectedCount, result.UsersCount);

            _userRepositoryMock.Verify(repo => repo.CountAsync(), Times.Once);
        }
    }
}