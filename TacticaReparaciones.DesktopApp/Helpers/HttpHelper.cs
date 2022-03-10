using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TacticaReparaciones.DesktopApp.Helpers
{
    public static class HttpHelper
    {
        const int TIMEOUT = 60 * 10000;

        public static RestRequest Get(string uri, string token, out string mensaje)
        {
            if (string.IsNullOrEmpty(uri))
            {
                mensaje = "La ruta no puede ser vacía.";
                return null;
            }

            RestRequest request = new RestRequest($"{uri}", Method.Get);
            request.RequestFormat = DataFormat.Json;
            request.Timeout = TIMEOUT;
            request.AddHeader("Content-Type", "application/json");
                  // .AddHeader("Authorization", $"Bearer {token}");

            mensaje = "Ok";
            return request;
        }
    }
}
