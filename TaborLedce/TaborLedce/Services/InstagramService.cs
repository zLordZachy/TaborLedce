using System.Threading.Tasks;
using Newtonsoft.Json;
using TaborLedce.Models;
using TaborLedce.PlatformSpecific;

namespace TaborLedce.Services
{
    public class InstagramService : IInstagramService
    {
        public const string AccesToken = "13844359759.30e3159.1edddf51e45041fda9bb8a516a1296a3";
        public const string userId = "30e3159f25f74b40b52c06c98b6e21f4";
        private readonly IHttpClient HttpClient;

        public InstagramService(IHttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<string> GetAccesToken()
        {
          return  await HttpClient.GetAsync($"https://www.instagram.com/oauth/authorize/?client_id=30e3159f25f74b40b52c06c98b6e21f4&redirect_uri=localhost://3000&response_type=token");
        }


        public async Task<RootObject> GetInstagramMetadata()
        {
            var json = await HttpClient.GetAsync($"https://api.instagram.com/v1/users/self/media/recent/?access_token={AccesToken}");
            return JsonConvert.DeserializeObject<RootObject>(json);
        } 

    }
}
