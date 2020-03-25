using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigSamplePlus.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IOptions<MyConfig> _config;

        public WeatherForecastController(IOptionsSnapshot<MyConfig> config)
        {
            _config = config;
        }

        [HttpGet]
        public MyResponse Get()
        {
            return new MyResponse
            {
                Id = _config.Value.Id,
                Name = _config.Value.Name
            };
        }
    }
}