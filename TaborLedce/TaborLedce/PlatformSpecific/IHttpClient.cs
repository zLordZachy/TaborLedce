using System.Threading.Tasks;

namespace TaborLedce.PlatformSpecific
{
    public interface IHttpClient
    {
        Task<string> GetAsync(string uri);
    }
}
