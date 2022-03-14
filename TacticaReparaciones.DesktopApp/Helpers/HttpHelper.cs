using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TacticaReparaciones.DesktopApp.Helpers
{
    public static class HttpHelper
    {
        const int TIMEOUT = 60 * 10000;

        public static async Task<IEnumerable<T>> Get<T>(string api, string uri, string token)
        {
            var options = new RestClientOptions(api)
            {
                ThrowOnAnyError = true,
                Timeout = 1000
            };
            var client = new RestClient(options);

            var request = new RestRequest($"{uri}", Method.Get);
            request.AddHeader("Content-Type", "application/json");

            var response = await client.GetAsync<IEnumerable<T>>(request);

            return response;
        }
    }
}
