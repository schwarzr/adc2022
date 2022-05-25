using Microsoft.Extensions.DependencyInjection;

namespace Adc.ClientSettings
{
    public class ClientSettingsBuilder : IClientSettingsBuilder
    {
        public ClientSettingsBuilder(IServiceCollection services)
        {
            Services = services;
        }

        public IServiceCollection Services { get; }
    }
}
