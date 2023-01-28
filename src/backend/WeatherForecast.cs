namespace backend;

/// <summary>
/// 날씨 DTO
/// </summary>
public class WeatherForecast
{
    /// <summary>
    /// 일자
    /// </summary>
    /// <example>2021-01-01</example>
    /// <value></value>
    public DateOnly Date { get; set; }
    /// <summary>
    /// 섭씨
    /// </summary>
    /// <example>1</example>
    /// <value></value>
    public int TemperatureC { get; set; }
    /// <summary>
    /// 화씨
    /// </summary>
    /// <exmaple>1</exmaple>
    /// <returns></returns>
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    /// <summary>
    /// 날씨 요약
    /// </summary>
    /// <example>Cool</example>
    /// <value></value>
    public string? Summary { get; set; }
}
