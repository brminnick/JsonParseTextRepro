using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonParseTextRepro
{
    public static class ApiService
    {
        readonly static HttpClient _client = new HttpClient
        {
            BaseAddress = new Uri("https://pundaycdn.azureedge.net"),
            DefaultRequestHeaders =
            {
                { "ZUMO-API-VERSION", "2.0.0" },
                { "Accept-Encoding", "gzip" },
                { "Accept", "application/json" }
            }
        };

        public static async Task<PunModel> GetPun()
        {
            using (var response = await _client.GetAsync("/tables/AzurePunModel/200").ConfigureAwait(false))
            {
                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<PunModel>(json);
            }
        }
    }
}
