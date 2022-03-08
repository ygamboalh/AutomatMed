using System.Configuration;
using System.Drawing;

namespace TacticaReparaciones.DesktopApp.Helpers
{
    public static class ColorHelper
    {
        public static string ObtenerColorEnHexadecimal(string claveColor)
        {
            var appSettings = ConfigurationManager.AppSettings;
            return appSettings[claveColor];
        }

        public static Color ObtenerColorEnRGB(string claveColor)
        {
            var appSettings = ConfigurationManager.AppSettings;
            var hexadecimalColor = appSettings[claveColor];

            return ColorTranslator.FromHtml(hexadecimalColor);
        }
    }
}
