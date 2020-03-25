using Microsoft.Extensions.Options;

namespace ConfigSamplePlus.Controllers
{
    public class MyService
    {
        private readonly IOptionsMonitor<MyConfig> _config;

        public MyService(IOptionsMonitor<MyConfig> config)
        {
            _config = config;
        }

        public MyResponse Get()
        {
            var configValue = _config.CurrentValue;
            return new MyResponse()
            {
                Id = configValue.Id,
                Name = configValue.Name
            };
        }
    }
}