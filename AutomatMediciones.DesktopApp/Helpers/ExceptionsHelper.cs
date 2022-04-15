using System;

namespace AutomatMediciones.DesktopApp.Helpers
{
    public static class ExceptionsHelper
    {
        public static string ObtenerMensajeExcepcion(Exception exception)
        {
            if (exception.InnerException != null)
            {
                return exception.InnerException.Message;
            }

            return exception.Message;
        }
    }
}
