using System.Diagnostics;

namespace AutomatMediciones.DesktopApp.Helpers
{
    public static class FileHelper
    {
        public static void AbrirArchivo(string nombreArchivo)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(nombreArchivo)
            {
                UseShellExecute = true
            };
            p.Start();
        }
    }
}
