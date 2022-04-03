using DevExpress.XtraEditors;
using System.Drawing;
using System.Windows.Forms;
using TacticaReparaciones.DesktopApp.Enums;
using TacticaReparaciones.DesktopApp.Helpers;

namespace TacticaReparaciones.DesktopApp.Pantallas.Principales
{
    public partial class frmPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.cmpMenu1.OnMenuSeleccionado += cmpMenuOnMenuSeleccionado;

            EstablecerNombreAplicacion();
            EstablecerFondoMdiPantalla();
            this.cmpMenu1.InicializarControl();

        }

        private void EstablecerNombreAplicacion()
        {
            this.Text = AplicacionHelper.ObtenerNombreDeAplicacion();
        }

        private void cmpMenuOnMenuSeleccionado(IndiceMenu indiceMenu)
        {
            switch (indiceMenu)
            {
                case IndiceMenu.Ingresos:
                    XtraForm frmIngresos = new frmIngresos();
                    AgregarPantalla(ref frmIngresos);
                    break;
                case IndiceMenu.Configuracion:
                    XtraForm frmConfiguracion = new frmConfiguracion();
                    AgregarPantalla(ref frmConfiguracion);
                    break;
            }
        }

        private void AgregarPantalla(ref XtraForm pantalla)
        {
            if (pantalla.Created)
            {
                pantalla.Focus();
            }
            else
            {
                pantalla.MdiParent = this;
                pantalla.Show();
            }
        }

        private void EstablecerFondoMdiPantalla()
        {
            MdiClient pantallaMDI;
            foreach (Control iterador in this.Controls)
            {
                var type = iterador.GetType();
                if (type.Name == "MdiClient")
                {
                    pantallaMDI = (MdiClient)iterador;
                    pantallaMDI.BackColor = Color.White;
                }
            }
        }
    }
}
