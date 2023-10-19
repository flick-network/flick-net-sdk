using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace flick_net_sdk.API
{
    public class APIService
    {
        private readonly HttpClient client;
        private readonly APIConfig config;

        public APIService(APIConfig config)
        {
            this.config = config;
            this.client = new HttpClient();
            this.client.BaseAddress = new Uri(GetBaseUrl(config.Environment));
            this.client.DefaultRequestHeaders.Add("Authorization", $"Bearer {config.ApiKey}");
        }

        private string GetBaseUrl(string environment)
        {
            return environment == "sandbox"
                ? "https://sandbox-api.flick.network"
                : "https://api.flick.network";
        }

        public async Task<HttpResponseMessage> SendRequestAsync(HttpRequestMessage request)
        {
            return await client.SendAsync(request);
        }
    }
}
