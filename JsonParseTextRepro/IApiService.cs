using System.Net.Http;
using System.Threading.Tasks;

using Refit;

namespace JsonParseTextRepro
{
    [Headers("ZUMO-API-VERSION: 2.0.0",
             "Accept-Encoding: gzip",
             "Accept: application/json")]
    public interface IApiService
    {
        [Get(@"/tables/AzurePunModel/{punNumber}")]
        Task<PunModel> GetAzurePunModel(int punNumber);

        [Get(@"/tables/AzurePunModel/200")]
        Task<HttpResponseMessage> GetAzurePunModel();
    }
}
