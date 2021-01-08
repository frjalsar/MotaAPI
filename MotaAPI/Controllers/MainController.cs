using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        /*private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }*/

        [HttpGet("/{info}")]
        public IActionResult Get(string info)
        {
            Console.Error.WriteLine("Number 1" + info);
            Console.WriteLine("Number 2" + info);

            return Ok("Virkaði: " + info);

        }

        public class Mot
        {
            public string strengur { get; set; }
        }

        [HttpPost("/post")]
        public async Task<ActionResult<Mot>> CreateMot(Mot mot)
        {
            try
            {
                if (mot == null)
                {
                    Console.Error.WriteLine("Number 3");
                    return BadRequest();
                }
                Console.Error.WriteLine("Number 4 " +mot.strengur);
                return Ok();
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Number 5");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new Competition");
            }
        }

    }
}
