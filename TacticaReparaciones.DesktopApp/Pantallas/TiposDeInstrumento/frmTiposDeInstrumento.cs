using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using TacticaReparaciones.DesktopApp.Helpers;
using TacticaReparaciones.Libs.Dtos;

namespace TacticaReparaciones.DesktopApp.Pantallas.TiposDeInstrumento
{
    public partial class frmTiposDeInstrumento : DevExpress.XtraEditors.XtraForm
    {
        string rutaApi;
        ICollection<TipoInstrumentoDto> tiposInstrumento = new List<TipoInstrumentoDto>();

        public frmTiposDeInstrumento()
        {
            InitializeComponent();
            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();
            EstablecerNombreYTitulo();
            EstablecerColorBotonPorDefecto();
            CargarTiposDeInstrumentos();

            repositoryItemButtonEdit1.Click += onSeleccionaTipoInstrumentoParaEditar;
        }

        private void onSeleccionaTipoInstrumentoParaEditar(object sender, EventArgs e)
        {
            var tipoInstrumento = gvTipoInstrumento.GetFocusedRow() as TipoInstrumentoDto;
            frmNuevoTipoInstrumento frmTipoInstrumento = new frmNuevoTipoInstrumento(TipoTransaccion.Actualizar);
            frmTipoInstrumento.NuevoTipoInstrumento = tipoInstrumento;
            frmTipoInstrumento.SetearValoresParaActualizar();
            frmTipoInstrumento.OnTipoInstrumentoModificado += OnTipoInstrumentoModificado;
            frmTipoInstrumento.Show();
        }

        private void OnTipoInstrumentoModificado(TipoInstrumentoDto tipoInstrumento)
        {
            tiposInstrumento = tiposInstrumento.Where(x => x.TipoInstrumentoId != tipoInstrumento.TipoInstrumentoId).ToList();
            tiposInstrumento.Add(tipoInstrumento);

            gcTipoInstrumento.DataSource = tiposInstrumento;
            gcTipoInstrumento.RefreshDataSource();

            SetearTotales();
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {tiposInstrumento.Count}";
            lblTotal.Visible = true;
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla3.lblTitulo.Text = "Tipos de Instrumento";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonPorDefecto()
        {
            btnAgregarNuevInstrumento.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnAgregarNuevInstrumento.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarNuevInstrumento.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private async void CargarTiposDeInstrumentos()
        {
            string uri = "/tipos-de-instrumento";
            var tiposDeInstrumentos = await HttpHelper.Get<TipoInstrumentoDto>(rutaApi, uri, "");
            tiposInstrumento = tiposDeInstrumentos;

            gcTipoInstrumento.DataSource = tiposInstrumento;

            SetearTotales();
        }

        private void btnAgregarNuevInstrumento_Click(object sender, System.EventArgs e)
        {
            frmNuevoTipoInstrumento frmTipoInstrumento = new frmNuevoTipoInstrumento(TipoTransaccion.Insertar);
            frmTipoInstrumento.OnTipoInstrumentoAgregado += OnTipoInstrumentoAgregado;
            frmTipoInstrumento.Show();
        }

        private void OnTipoInstrumentoAgregado(TipoInstrumentoDto tipoInstrumento)
        {
            tiposInstrumento.Add(tipoInstrumento);
            gcTipoInstrumento.DataSource = tipoInstrumento;
            gcTipoInstrumento.RefreshDataSource();

            SetearTotales();
        }
    }
}