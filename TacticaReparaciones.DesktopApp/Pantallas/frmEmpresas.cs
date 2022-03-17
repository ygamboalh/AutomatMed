using System;
using TacticaReparaciones.DesktopApp.Helpers;
using TacticaReparaciones.Libs.Dtos;

namespace TacticaReparaciones.DesktopApp.Pantallas
{
    public partial class frmEmpresas : DevExpress.XtraEditors.XtraForm
    {
        public delegate void EmpresaSeleccionada(EmpresaDto empresa);
        public event EmpresaSeleccionada OnSeleccionaEmpresa;

        string rutaApi;
        EmpresaDto empresaSeleccionada;

        public frmEmpresas()
        {
            InitializeComponent();

            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();
            CargarDatosDeEmpresas();
            EstablecerNombreYTituloPopupEmpresas();
        }

        private async void CargarDatosDeEmpresas()
        {
            string uri = "/empresas";
            var empresas = await HttpHelper.Get<EmpresaDto>(rutaApi, uri, "");

            gcEmpresas.DataSource = empresas;

        }

        private void EstablecerNombreYTituloPopupEmpresas()
        {
            this.Text = "";
            ctlEncabezadoPopup.lblTitulo.Text = "Listado de Empresas";
            ctlEncabezadoPopup.EstablecerColoresDeFondoYLetra();
        }

        private void gcEmpresas_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                ObtenerEmpresaSeleccionada();
            }
        }

        private void gcEmpresas_DoubleClick(object sender, EventArgs e)
        {
            ObtenerEmpresaSeleccionada();
        }

        public void ObtenerEmpresaSeleccionada()
        {
            empresaSeleccionada = gvEmpresas.GetFocusedRow() as EmpresaDto;
            OnSeleccionaEmpresa?.Invoke(empresaSeleccionada);
            this.Close();

        }
    }
}