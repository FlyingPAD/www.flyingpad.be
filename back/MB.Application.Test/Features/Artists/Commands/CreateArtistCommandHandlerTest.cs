using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Artists.Commands.CreateArtist;
using MB.Domain.Entities;
using Moq;
using Xunit;

namespace MB.Application.Test.Features.Artists.Commands
{
    public class CreateArtistCommandHandlerTest
    {
        private readonly Mock<IMapper> mapperMock;
        private readonly Mock<IBaseRepository<Artist>> repoMock;
        private readonly CreateArtistCommandHandler handler;
        private readonly CreateArtistCommandValidator validator;

        public CreateArtistCommandHandlerTest()
        {
            mapperMock = new Mock<IMapper>();
            repoMock = new Mock<IBaseRepository<Artist>>();
            validator = new CreateArtistCommandValidator();
            handler = new CreateArtistCommandHandler(mapperMock.Object, repoMock.Object, validator);
        }

        [Fact]
        public async System.Threading.Tasks.Task Handle_Should_Call_CreateAsync_HappyFlow()
        {
            // Arrange

            var artistName = "azertyuio";

            repoMock.Setup(x => x.CreateAsync(It.Is<Artist>(x => x.Name == artistName))).ReturnsAsync(new Artist
            {
                BusinessId = Guid.NewGuid()
            });

            var request = new CreateArtistCommand
            {
                Name = artistName
            };

            var validationResult = await validator.ValidateAsync(request);

            //Act

            await handler.Handle(request, new CancellationToken());

            //Assert

            repoMock.Verify(x => x.CreateAsync(It.Is<Artist>(x => x.Name == artistName)), Times.Once);
        }

        [Fact]
        public async System.Threading.Tasks.Task Handle_Should_Explode()
        {
            // Arrange

            var artistName = "azertyuio";

            repoMock.Setup(x => x.CreateAsync(It.Is<Artist>(x => x.Name == artistName))).ThrowsAsync(new ArgumentNullException());

            var request = new CreateArtistCommand
            {
                Name = artistName
            };

            // Act and Assert

            await Assert.ThrowsAsync<ArgumentNullException>(() => handler.Handle(request, new CancellationToken()));
        }
    }
}