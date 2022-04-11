using DevExpress.XtraEditors;
using System;
using AutomatMediciones.DesktopApp.Pantallas.Clasificaciones;
using AutomatMediciones.DesktopApp.Pantallas.Marcas;
using AutomatMediciones.DesktopApp.Pantallas.Modelos;
using AutomatMediciones.DesktopApp.Pantallas.TiposDeInstrumento;
using AutomatMediciones.DesktopApp.Pantallas.VariablesDeMedicion;

namespace AutomatMediciones.DesktopApp.Pantallas
{
    public partial class frmConfiguracion : DevExpress.XtraEditors.XtraForm
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void tipoInstrumentoMenu_Click(object sender, EventArgs e)
        {
            XtraForm frmTiposDeInstrumento = new frmTiposDeInstrumento();
            AgregarPantalla(ref frmTiposDeInstrumento);
        }

        private void AgregarPantalla(ref XtraForm pantalla)
        {
            if (pantalla.Created)
            {
                pantalla.Focus();
            }
            else
            {
                pantalla.MdiParent = this.ParentForm;
                pantalla.Show();
            }
        }

        private void marcaMenu_Click(object sender, EventArgs e)
        {
            XtraForm frmMarcas = new frmMarcas();
            AgregarPantalla(ref frmMarcas);
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            XtraForm frmModelos = new frmModelos();
            AgregarPantalla(ref frmModelos);
        }

        private void clasificacionInstrumentoMenu_Click(object sender, EventArgs e)
        {
            XtraForm frmClasificaciones = new frmClasificaciones();
            AgregarPantalla(ref frmClasificaciones);
        }

        private void instrumentosMenu_Click(object sender, EventArgs e)
        {
            XtraForm nuevoInstrumento = new frmNuevoInstrumento();
            AgregarPantalla(ref nuevoInstrumento);
        }

        private void variableMedicionMenu_Click(object sender, EventArgs e)
        {
            XtraForm variableMedicion = new frmVariablesDeMedicion();
            AgregarPantalla(ref variableMedicion);
        }
    }
}