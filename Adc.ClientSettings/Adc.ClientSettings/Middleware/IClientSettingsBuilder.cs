using Microsoft.Extensions.DependencyInjection;

namespace Adc.ClientSettings
{
    public interface IClientSettingsBuilder
    {
        IServiceCollection Services { get; }
    }
}
