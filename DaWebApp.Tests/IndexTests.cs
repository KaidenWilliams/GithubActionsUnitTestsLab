using Moq;
using Microsoft.Extensions.Logging;
namespace DaActualWebApp.Pages.Tests;

public class IndexTests
{
    
    private readonly Mock<ILogger<IndexModel>> _logger = new Mock<ILogger<IndexModel>>();
    IndexModel _sut;

    public IndexTests() {
        _sut = new IndexModel(_logger.Object);
    }

    [Fact]
    public void CalcSecret_ShouldReturnSuccess_WhenInputIsSecret() {

        //Arrange
        string input = "secret";

        //Act
         var result = _sut.CalcSecret(input);

        //Assert
        Assert.Equal(result, "You entered the secret!");
    }


    [Fact]
    public void CalcSecret_ShouldReturnFail_WhenInputNotSecret() {

        //Arrange
        string input = "this will fail";

        //Act
         var result = _sut.CalcSecret(input);

        //Assert
        Assert.Equal(result, "You Failed");

    }

}