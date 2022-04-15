using System.Configuration;

namespace AutomatMediciones.DesktopApp.Helpers
{
    public static class AplicacionHelper
    {
        public static string ObtenerNombreDeAplicacion()
        {
            var appSettings = ConfigurationManager.AppSettings;
            var nombreAplicacion = appSettings["NombreAplicacion"];
            return nombreAplicacion;
        }

        public static string ObtenerCadenaConexion(string nombreCadena)
        {
            var appSettings = ConfigurationManager.AppSettings;
            var cadenaConexion = appSettings[nombreCadena];
            return cadenaConexion;

        }

        public static string ObtenerHostCorreo()
        {
            var appSettings = ConfigurationManager.AppSettings;
            var servidorCorreo = appSettings["ServidorSMTP"];


            return servidorCorreo;

        }

        public static string ObtenerCorreoNotificacion()
        {
            var appSettings = ConfigurationManager.AppSettings;
            var correo = appSettings["DireccionCorreoNotificaciones"];


            return correo;

        }

        public static string ObtenerPassCorreoNotificacion()
        {
            var appSettings = ConfigurationManager.AppSettings;
            var password = appSettings["PasswordCorreoNotificaciones"];


            return password;

        }

        public static string ObtenerApiKeyGridMail()
        {
            var appSettings = ConfigurationManager.AppSettings;
            var apiKey = appSettings["ApiKeyGridMail"];


            return apiKey;

        }

        public static string ObtenerDataBaseServer(string nombreCadena)
        {
            var appSettings = ConfigurationManager.AppSettings;
            var cadenaConexion = appSettings[nombreCadena];

            var cadena = cadenaConexion.Split(";");

            var segundaCadena = cadena[0].Split("Server=");
            var terceraCadena = cadena[2].Split("Database=");


            return $"{segundaCadena[1]}|{terceraCadena[1]}";

        }
    }
}
