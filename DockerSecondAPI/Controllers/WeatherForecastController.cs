using ClassLibrary4;
using ClassLibrary5;
using ClassLibrary6;
using Microsoft.AspNetCore.Mvc;

namespace DockerSecondAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

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

        [HttpGet]
        public IActionResult GetCl1()
        {
            Class4 class4 = new Class4();
            return Ok(class4.Name);
        }
        [HttpGet]
        public IActionResult GetCl2()
        {
            Class5 class5 = new Class5();
            return Ok(class5.Name);
        }
        [HttpGet]
        public IActionResult GetCl3()
        {
            Class6 class6 = new Class6();
            return Ok(class6.Name);
        }
    }
}
