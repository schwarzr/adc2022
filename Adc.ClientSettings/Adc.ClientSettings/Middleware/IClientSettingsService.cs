using System.IO;
using System.Threading.Tasks;

namespace Adc.ClientSettings
{
    public interface IClientSettingsService
    {
        Task WriteSettingsAsync(Stream response);
    }
}
