using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Refit;

namespace JsonParseTextRepro
{
    public class ApiService
    {
        const string _baseApiUrl = "https://pundaycdn.azureedge.net";
        readonly IApiService _apiServiceClient = RestService.For<IApiService>(CreateHttpClient(_baseApiUrl));

        public Task<PunModel> GetPun(int punNumber) => _apiServiceClient.GetAzurePunModel(punNumber);
        public async Task<PunModel> GetPun()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("ZUMO-API-VERSION", "2.0.0");
                client.DefaultRequestHeaders.AcceptEncoding.Add(new System.Net.Http.Headers.StringWithQualityHeaderValue("gzip"));

                using (var response = await client.GetAsync($"{_baseApiUrl}/tables/AzurePunModel/200").ConfigureAwait(false))
                {
                    var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return JsonConvert.DeserializeObject<PunModel>(json);
                }
            }
        }

        static HttpClient CreateHttpClient(string url) => new HttpClient { BaseAddress = new Uri(url) };
    }
}
