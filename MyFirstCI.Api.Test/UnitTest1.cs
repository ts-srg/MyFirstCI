using MyFirstCI.Api.Controllers;

namespace MyFirstCI.Api.Test;

public class UnitTest1
{
    [Fact]
    public void Get_ReturnFiveValue()
    {
        //Arrange
        var controller = new WeatherController();
        //Act
        var result = controller.Get();
        //Assert
        Assert.Equal(5, result.Length);

    }

    [Fact]
    public void Get_ReturnAllFutureValue()
    {
        //Arrange
        var controller = new WeatherController();
        //Act
        var result = controller.Get();
        //Assert
        foreach (var item in result)
        {
            Assert.True(item.Date > DateOnly.FromDateTime(DateTime.Now));
        }

    }

    [Fact]
    public void Get_ReturnTenValue()
    {
        //Arrange
        var controller = new WeatherController();
        //Act
        var result = controller.Get();
        //Assert
        Assert.Equal(10, result.Length);

    }
}