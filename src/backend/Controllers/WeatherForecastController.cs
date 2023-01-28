using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

/// <summary>
/// 날씨 조회 컨트롤러
/// </summary>
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    /// <summary>
    /// 날씨 데이터를 조회합니다.
    /// </summary>
    /// <param name="logger"></param>
    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// 날씨 데이터를 모두 조회합니다.
    /// </summary>
    /// <returns></returns>
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
    
    /// <summary>
    /// 입력받은 day 값 이후에 대한 날씨 데이터를 조회합니다.
    /// </summary>
    /// <param name="day" example="5">날짜값입니다.</param>
    /// <returns></returns>
    [HttpGet("{day}", Name = "GetWeatherForecastById")]
    public WeatherForecast Get(int day)
    {
        return new() {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(day)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        };
    }
}
