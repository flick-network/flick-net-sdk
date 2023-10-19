using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using flick_net_sdk.API;
using flick_net_sdk.Models;

namespace flick_net_sdk.Services
{
    public class BillsService
    {
        private readonly APIService apiService;

        public BillsService(APIConfig config)
        {
            this.apiService = new APIService(config);
        }

        public async Task<HttpResponseMessage> OnboardEGSAsync(EGSData egsData)
        {
            var json = JsonSerializer.Serialize(egsData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var request = new HttpRequestMessage(HttpMethod.Post, "/egs/onboard");
            request.Content = content;
            return await apiService.SendRequestAsync(request);
        }

        public async Task<HttpResponseMessage> DoComplianceCheckAsync(string egsUuid)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"/egs/compliance-check/{egsUuid}");
            return await apiService.SendRequestAsync(request);
        }

        public async Task<HttpResponseMessage> GenerateInvoiceAsync(InvoiceData invoiceData)
        {
            var json = JsonSerializer.Serialize(invoiceData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var request = new HttpRequestMessage(HttpMethod.Post, "/invoice/generate");
            request.Content = content;
            return await apiService.SendRequestAsync(request);
        }
    }
}
