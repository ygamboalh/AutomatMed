using System;
using System.Windows.Forms;
using AutomatMediciones.DesktopApp.Pantallas.Principales;

namespace AutomatMediciones.DesktopApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            try
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmPrincipal());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
