using System.Net.Http;
using System.Threading.Tasks;
using TaborLedce.Droid.PlatformSpecific;
using TaborLedce.PlatformSpecific;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidHttpClient))]
namespace TaborLedce.Droid.PlatformSpecific
{
    public class AndroidHttpClient : IHttpClient
    {
        public async Task<string> GetAsync(string uri)
        {
            using (var httpClient = new HttpClient())
            {

                HttpResponseMessage response = await httpClient.GetAsync(uri);

                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}