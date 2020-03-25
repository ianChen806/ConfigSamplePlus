using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ConfigSamplePlus.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly MyService _service;

        public WeatherForecastController(MyService service)
        {
            _service = service;
        }

        [HttpGet]
        public MyResponse Get()
        {
            return _service.Get();
        }
    }
}