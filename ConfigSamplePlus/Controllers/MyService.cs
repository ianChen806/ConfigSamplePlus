using Microsoft.Extensions.Options;

namespace ConfigSamplePlus.Controllers
{
    public class MyService
    {
        private readonly IOptionsSnapshot<MyConfig> _config;

        public MyService(IOptionsSnapshot<MyConfig> config)
        {
            _config = config;
        }

        public MyResponse Get()
        {
            var configValue = _config.Value;
            return new MyResponse()
            {
                Id = configValue.Id,
                Name = configValue.Name
            };
        }
    }
}