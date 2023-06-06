using Microsoft.AspNetCore.Mvc;

namespace CQRSWithCleanArchitecture.Controllers;

[ApiVersion("1.0")]
[ApiVersion("1.1")]
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] OldApiVersion = new[]
    {
        "1.0"
    };
    private static readonly string[] NewApiVersion = new[]
   {
        "1.1"
    };
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }
    [MapToApiVersion("1.0")]
    public IEnumerable<string> Get()
    {
        return OldApiVersion;
    }
    [MapToApiVersion("1.1")]
    public IEnumerable<string> GetW()
    {
        return NewApiVersion;
    }

}

