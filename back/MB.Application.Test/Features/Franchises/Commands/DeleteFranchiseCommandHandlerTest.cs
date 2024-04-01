using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Franchises.Commands.DeleteFranchise;
using MB.Application.Features.Task.Commands.DeleteTask;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Test.Features.Franchises.Commands
{
    public class DeleteFranchiseCommandHandlerTest
    {
        private readonly DeleteFranchiseCommandHandler _handler;
        private readonly Mock<IMapper> _mapperMock;
        private readonly Mock<IBaseRepository<Franchise>> _repoMock;

        public DeleteFranchiseCommandHandlerTest()
        {
            _mapperMock = new Mock<IMapper>();
            _repoMock = new Mock<IBaseRepository<Franchise>>();
            _handler = new DeleteFranchiseCommandHandler(_mapperMock.Object, _repoMock.Object);
        }

        [Fact]
        public async System.Threading.Tasks.Task HandleShouldCallDeleteAsync()
        {
            // Arrange
            var franchiseId = Guid.NewGuid();
            var request = new DeleteFranchiseCommand { FranchiseId = franchiseId };
            var franchise = new Franchise { BusinessId = franchiseId };

            _repoMock.Setup(x => x.GetByBusinessIdAsync(franchiseId)).ReturnsAsync(franchise);

            // Act
            await _handler.Handle(request, new CancellationToken());

            // Assert
            _repoMock.Verify(x => x.DeleteAsync(It.Is<Franchise>(f => f.BusinessId == franchiseId)), Times.Once(), "The franchise should be deleted once if it exists.");
        }
    }
}
