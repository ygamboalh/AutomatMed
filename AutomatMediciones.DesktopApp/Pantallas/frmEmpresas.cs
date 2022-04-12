using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Linq;

namespace AutomatMediciones.DesktopApp.Pantallas
{
    public partial class frmEmpresas : DevExpress.XtraEditors.XtraForm
    {
        public delegate void EmpresaSeleccionada(EmpresaDto empresa);
        public event EmpresaSeleccionada OnSeleccionaEmpresa;

        EmpresaDto empresaSeleccionada;
        private readonly EmpresaService _empresaService;

        public frmEmpresas(EmpresaService empresaService)
        {
            InitializeComponent();

            _empresaService = empresaService;

            CargarDatosDeEmpresas();
            EstablecerNombreYTituloPopupEmpresas();

        }

        private void CargarDatosDeEmpresas()
        {
            var resultado = _empresaService.ObtenerEmpresas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            gcEmpresas.DataSource = resultado.Data;
            lblTotalRegistros.Text = $"Total Registros: {resultado.Data.Count()}";

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