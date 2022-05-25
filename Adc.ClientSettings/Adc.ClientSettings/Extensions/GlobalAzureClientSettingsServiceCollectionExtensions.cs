using Adc.ClientSettings;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AdcClientSettingsServiceCollectionExtensions
    {
        public static IClientSettingsBuilder AddClientSettings(this IServiceCollection services)
        {
            return new ClientSettingsBuilder(services);
        }
    }
}
