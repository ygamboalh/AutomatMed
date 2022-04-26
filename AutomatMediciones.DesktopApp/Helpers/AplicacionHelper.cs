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
