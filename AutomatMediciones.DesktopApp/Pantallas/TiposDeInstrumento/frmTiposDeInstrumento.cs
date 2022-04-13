using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomatMediciones.DesktopApp.Pantallas.TiposDeInstrumento
{
    public partial class frmTiposDeInstrumento : DevExpress.XtraEditors.XtraForm
    {
        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private readonly TipoDeInstrumentoService _tipoInstrumentoService;

        ICollection<TipoInstrumentoDto> tiposInstrumento = new List<TipoInstrumentoDto>();

        public frmTiposDeInstrumento(TipoDeInstrumentoService tipoInstrumentoService)
        {
            InitializeComponent();

            _tipoInstrumentoService = tipoInstrumentoService;

            EstablecerNombreYTitulo();
            EstablecerColorBotonPorDefecto();
            CargarTiposDeInstrumentos();

            repositoryItemButtonEdit1.Click += onSeleccionaTipoInstrumentoParaEditar;

        }

        private void onSeleccionaTipoInstrumentoParaEditar(object sender, EventArgs e)
        {
            var tipoInstrumento = gvTipoInstrumento.GetFocusedRow() as TipoInstrumentoDto;

            if (tiposInstrumento == null) return;

            var frmTipoInstrumento = new frmNuevoTipoInstrumento(TipoTransaccion.Actualizar, serviceProvider.GetService<TipoDeInstrumentoService>());
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


        private void CargarTiposDeInstrumentos()
        {
            var resultado = _tipoInstrumentoService.ObtenerTiposDeInstrumento();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            tiposInstrumento = resultado.Data;
            gcTipoInstrumento.DataSource = tiposInstrumento;

            SetearTotales();
        }

        private void btnAgregarNuevInstrumento_Click(object sender, System.EventArgs e)
        {
            var frmTipoInstrumento = new frmNuevoTipoInstrumento(TipoTransaccion.Insertar, serviceProvider.GetService<TipoDeInstrumentoService>());      
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