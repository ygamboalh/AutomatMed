using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;


namespace TacticaReparaciones.DesktopApp.Helpers
{
    public static class HttpHelper
    {
        public static async Task<List<T>> Get<T>(string api, string uri, string token)
        {
            var cliente = new RestClient(api);
            try
            {
                var peticion = new RestRequest($"{uri}", Method.Get);
                peticion.AddHeader("Content-Type", "application/json");
                var respuesta = await cliente.GetAsync<List<T>>(peticion);

                return respuesta;
            }
            finally
            {
                cliente.Dispose();
            }
        }

        public static async Task<bool> Post<T>(T objetoParaGuardar, string rutaApi, string endpoint, string token)
        {
            var cliente = new RestClient(rutaApi);

            try
            {
                var peticion = new RestRequest(endpoint, Method.Post);
                peticion.RequestFormat = DataFormat.Json;
                peticion.AddBody(objetoParaGuardar);
                var respuesta = await cliente.ExecuteAsync<T>(peticion);


                if (respuesta.StatusCode != HttpStatusCode.OK)
                {
                    string message = string.IsNullOrEmpty(respuesta.Content) ? respuesta.ErrorMessage : respuesta.Content;
                    var tacticaException = new Exception(message, respuesta.ErrorException);
                    throw tacticaException;
                }

                return true;
            }
            finally
            {
                cliente.Dispose();
            }
        }
    }
}
