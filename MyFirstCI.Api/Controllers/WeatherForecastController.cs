using Microsoft.AspNetCore.Mvc;

namespace MyFirstCI.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherController : ControllerBase
{
    [HttpGet("WeatherForeCast")]
    [Produces("application/json")]
    public WeatherForecast[] Get()
    {
        var forcast = Enumerable.Range(1, 5).Select(index =>
            new WeatherForecast(DateOnly.FromDateTime(DateTime.Now.AddDays(index)),Random.Shared.Next(-20, 55))).ToArray();

            return forcast;
        }
    }

public record WeatherForecast(DateOnly Date, int TempretureC)
{
    public int TempretureK => TempretureC;
}