using Microsoft.AspNetCore.Mvc;
using ClassLibrary1;
using ClassLibrary2;
using ClassLibrary3;
namespace DockerFirstAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
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
            Class1 class1 = new Class1();
            return Ok(class1.Name);
        }
        [HttpGet]
        public IActionResult GetCl2()
        {
            Class2 class2 = new Class2();
            return Ok(class2.Name);
        }
        [HttpGet]
        public IActionResult GetCl3()
        {
            Class3 class3 = new Class3();
            return Ok(class3.Name);
        }


    }
}
