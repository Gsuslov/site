using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace site.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FishHeadController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public FishHeadController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<FishHead> Get()
        {
            var rng = new Random();
            return Enumerable.Range(0, 1).Select(index => new FishHead
            {
                Fish = "Zozo",
                River = "Vibery rechusku",
                RiverInfo = "Infa o rechuske",
                Comments = "oh shit, here go again"
            })
            .ToArray();
        }

    }
}
