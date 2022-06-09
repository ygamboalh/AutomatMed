using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
