using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.TagCategories.Queries.CountTagCategories;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Test.Features.TagCategories.Queries
{
    public class CountTagCategoriesQueryTest
    {
        private Mock<IBaseRepository<TagCategory>> _tagCategoryRepositoryMock;
        private CountTagCategoriesQueryHandler _handler;

        public CountTagCategoriesQueryTest()
        {
            _tagCategoryRepositoryMock = new Mock<IBaseRepository<TagCategory>>();
            _handler = new CountTagCategoriesQueryHandler(_tagCategoryRepositoryMock.Object);
        }

        [Fact]
        public async System.Threading.Tasks.Task Handle_Should_Return_Correct_Count() 
        {
            // Arrange

            var expectedCount = 42;

            _tagCategoryRepositoryMock.Setup(repo => repo.CountAsync()).ReturnsAsync(expectedCount);

            var request = new CountTagCategoriesQuery();

            // Act

            var result = await _handler.Handle(request, new CancellationToken());

            // Assert

            Assert.True(result.Success);
            Assert.Equal($"Total Tag Categories : {expectedCount}", result.Message);
            Assert.Equal(expectedCount, result.TagCategoriesCount);

            _tagCategoryRepositoryMock.Verify(repo => repo.CountAsync(), Times.Once);
        }
    }
}