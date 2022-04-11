
using System.Windows.Forms;
using AutomatMediciones.DesktopApp.Helpers;

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
