using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Nagaira.Core.Extentions.Enumeradores;
using Nagaira.Core.Extentions.Exceptions;
using Nagaira.Core.Extentions.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Celdas
{
    public partial class frmNuevaCelda : DevExpress.XtraEditors.XtraForm
    {
        private readonly CeldaService _celdaService;

        public delegate void CeldaAgregada(CeldaDto celda);
        public event CeldaAgregada OnCeldaAgregada;

        public delegate void CeldaModificada(CeldaDto celda);
        public event CeldaModificada OnCeldaModificada;


        public TipoTransaccion TipoTransaccion { get; set; }
        public CeldaDto NuevaCelda { get; set; }

        List<EstadoCeldaDto> estados = new List<EstadoCeldaDto>();
        List<TipoCeldaDto> tiposDeCelda = new List<TipoCeldaDto>();

        public frmNuevaCelda(TipoTransaccion tipoTransaccion, CeldaService celdaService)
        {
            InitializeComponent();
            TipoTransaccion = tipoTransaccion;
            _celdaService = celdaService;

            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonGuardar();

            estados.Clear();
            tiposDeCelda.Clear();

            CargarTiposDeCeldas();
            CargarEstados();
            NuevaCelda = new CeldaDto();

        }

        private void CargarEstados()
        {
            var resultado = _celdaService.ObtenerEstadosDeCelda();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            estados = resultado.Data;
            lookupEstado.Properties.DataSource = resultado.Data;

            lookupEstado.Properties.DisplayMember = "Descripcion";
            lookupEstado.Properties.ValueMember = "Id";
        }


        private void CargarTiposDeCeldas()
        {
            var resultado = _celdaService.ObtenerTiposDeCeldas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            tiposDeCelda = resultado.Data;
            lookupTipoCelda.Properties.DataSource = resultado.Data;

            lookupTipoCelda.Properties.DisplayMember = "Descripcion";
            lookupTipoCelda.Properties.ValueMember = "Id";
        }


        public void SetearValoresParaActualizar()
        {
            txtNumeroSerie.Text = NuevaCelda.NumeroSerie;
            lookupEstado.EditValue = NuevaCelda.EstadoId;
            lookupTipoCelda.EditValue = NuevaCelda.TipoCeldaId;
            dateFechaAdquisicion.EditValue = NuevaCelda.FechaAdquisicion.HasValue ? NuevaCelda.FechaAdquisicion.Value : null;
            dateFechaFabricacion.EditValue = NuevaCelda.FechaFabricacion.HasValue ? NuevaCelda.FechaFabricacion.Value : null;

        }

        private void PrepararNuevaCelda()
        {
            NuevaCelda.TipoCeldaId = (int)lookupTipoCelda.EditValue;
            NuevaCelda.NumeroSerie = txtNumeroSerie.Text;
            NuevaCelda.FechaFabricacion = dateFechaFabricacion.EditValue != null ? (DateTime)dateFechaFabricacion.EditValue : null;
            NuevaCelda.FechaAdquisicion = dateFechaAdquisicion.EditValue != null ? (DateTime)dateFechaAdquisicion.EditValue : null;
            NuevaCelda.EstadoId = (int)lookupEstado.EditValue;
        }


        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = TipoTransaccion == TipoTransaccion.Insertar ? "Agregar Celda" : "Modificar Celda";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarCelda.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarCelda.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarCelda.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private bool GuardarCelda()
        {
            try
            {
                var resultado = _celdaService.RegistrarCelda(NuevaCelda);
                if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private bool ActualizarCelda()
        {
            try
            {
                var resultado = _celdaService.ActualizarCelda(NuevaCelda);
                if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void btnGuardarCelda_Click(object sender, EventArgs e)
        {
            PrepararNuevaCelda();

            if (!EsValidaLaInformacionIngresadaParaNuevaCelda(out string mensaje))
            {
                Notificaciones.MensajeAdvertencia(mensaje);
                return;
            }

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));
            if (TipoTransaccion == TipoTransaccion.Insertar)
            {
                if (GuardarCelda())
                {
                    Notificaciones.MensajeConfirmacion("¡La celda se ha registrado exitosamente!");
                    NuevaCelda.Estado = estados.FirstOrDefault(x => x.Id == (int)lookupEstado.EditValue);
                    NuevaCelda.TipoCelda = tiposDeCelda.FirstOrDefault(x => x.Id == (int)lookupTipoCelda.EditValue);
                    OnCeldaAgregada?.Invoke(NuevaCelda);
                    this.Close();
                }
            }
            else
            {
                if (ActualizarCelda())
                {

                    Notificaciones.MensajeConfirmacion("¡La celda se ha actualizado exitosamente!");
                    NuevaCelda.Estado = estados.FirstOrDefault(x => x.Id == (int)lookupEstado.EditValue);
                    NuevaCelda.TipoCelda = tiposDeCelda.FirstOrDefault(x => x.Id == (int)lookupTipoCelda.EditValue);
                    OnCeldaModificada?.Invoke(NuevaCelda);
                    this.Close();
                }
            }

            SplashScreenManager.CloseForm();

        }

        private bool EsValidaLaInformacionIngresadaParaNuevaCelda(out string mensaje)
        {
            if (string.IsNullOrEmpty(NuevaCelda.NumeroSerie))
            {
                mensaje = "Es necesario ingresar una serie para la celda.";
                return false;
            }
            mensaje = "Ok";
            return true;
        }
    }
}