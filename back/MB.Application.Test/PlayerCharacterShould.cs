using MB.Domain.Entities;
using Xunit;
using Xunit.Abstractions;

namespace MB.Application.Test;

[Trait("Category", "PlayerCharacter")]
public class PlayerCharacterShould
{
    // Check cette histoire de disposable et de création d'instance ( à part ) à injecter dans le constructeur pour réutiliser la même dans plusieurs séries de tests
    // => Sharing Context Between Tests During Execution

    // Y'a aussi cette histoire de CollectionDefinition



    // Output Syntax

    private readonly ITestOutputHelper _output;
    private readonly PlayerCharacter _sut;

    public PlayerCharacterShould(ITestOutputHelper output)
    {
        _output = output;
        //_output.WriteLine("Restore Method Test");
        _sut = new PlayerCharacter();
    }

    [Fact(Skip = "Testing the Skipping Function")]
    public void testPlayerCharacter()
    {
        // Arrange ( see constructor )


        // Act

        _sut.IsActive = true;

        // Assert

        Assert.True(_sut.IsActive);
    }

    [Fact]
    public void testRestore()
    {
        _output.WriteLine("Restore Method Test");

        // Arrange ( see constructor )


        // Act

        _sut.Restore();

        // Assert

        Assert.InRange(_sut.Health, 0, 150);
    } 
}
