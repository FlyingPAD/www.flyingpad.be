using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Artists.Commands.UpdateArtist;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Test.Features.Artists.Commands
{
    public class UpdateArtistCommandHandlerTest
    {
        private readonly Mock<IBaseRepository<Artist>> _artistRepoMock;
        private readonly UpdateArtistCommandValidator _validator;
        private readonly UpdateArtistCommandHandler _handler;

        public UpdateArtistCommandHandlerTest()
        {
            _artistRepoMock = new Mock<IBaseRepository<Artist>>();
            _validator = new UpdateArtistCommandValidator();
            _handler = new UpdateArtistCommandHandler(_validator, _artistRepoMock.Object);
        }

        [Fact(Skip = "Temp Skip")]
        public async System.Threading.Tasks.Task Handle_Should_Call_UpdateAsync_Happy_Flow()
        {
            // Arrange

            var request = new UpdateArtistCommand
            {
                BusinessId = Guid.NewGuid(),
                Name = "Test Name"
            };

            var validationResult = await _validator.ValidateAsync(request);

            // Act

            await _handler.Handle(request, new CancellationToken());

            // Assert / Verify

            _artistRepoMock.Verify(x => x.UpdateAsync(It.Is<Artist>(x => x.Name == request.Name)), Times.Once);

        }

    }
}
