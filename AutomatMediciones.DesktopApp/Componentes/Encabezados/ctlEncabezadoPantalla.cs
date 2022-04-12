
using AutomatMediciones.DesktopApp.Helpers;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Componentes.Encabezados
{
    public partial class ctlEncabezadoPantalla : UserControl
    {
        public ctlEncabezadoPantalla()
        {
            InitializeComponent();

        }

        public void EstablecerColoresDeFondoYLetra()
        {
            this.BackColor = ColorHelper.ObtenerColorEnRGB("Primary500");
            this.ForeColor = ColorHelper.ObtenerColorEnRGB("Secondary50");
        }
    }
}
