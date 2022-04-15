﻿using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;

namespace AutomatMediciones.DesktopApp.Pantallas.TiposDeInstrumento
{
    public partial class frmNuevoTipoInstrumento : DevExpress.XtraEditors.XtraForm
    {
        private readonly TipoDeInstrumentoService _tipoInstrumentoService;

        public delegate void TipoInstrumentoAgregado(TipoInstrumentoDto tipoInstrumento);
        public event TipoInstrumentoAgregado OnTipoInstrumentoAgregado;

        public delegate void TipoInstrumentoModificado(TipoInstrumentoDto tipoInstrumento);
        public event TipoInstrumentoAgregado OnTipoInstrumentoModificado;

        public TipoTransaccion TipoTransaccion { get; set; }
        public TipoInstrumentoDto NuevoTipoInstrumento { get; set; }

        public frmNuevoTipoInstrumento(TipoTransaccion tipoTransaccion, TipoDeInstrumentoService tipoInstrumentoService)
        {
            InitializeComponent();

            TipoTransaccion = tipoTransaccion;
            _tipoInstrumentoService = tipoInstrumentoService;

            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonGuardar();

            NuevoTipoInstrumento = new TipoInstrumentoDto();

        }

        public void SetearValoresParaActualizar()
        {
            txtDescripcion.Text = NuevoTipoInstrumento.Descripcion;
            txtMetodologia.Text = NuevoTipoInstrumento.Metodologia;
            txtResumen.Text = NuevoTipoInstrumento.Resumen;
        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            this.Text = "";
            ctlEncabezadoPantalla1.lblTitulo.Text = TipoTransaccion == TipoTransaccion.Insertar ? "Agregar Tipo de Instrumento" : "Modificar Tipo de Instrumento";
            ctlEncabezadoPantalla1.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarInstrumento.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarInstrumento.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarInstrumento.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void btnGuardarInstrumento_Click(object sender, EventArgs e)
        {

            PrepararNuevoTipoInstrumento();

            if (!EsValidaLaInformacionIngresadaParaNuevoTipoInstrumento(out string mensaje))
            {
                Notificaciones.MensajeAdvertencia(mensaje);
                return;
            }

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));

            if (TipoTransaccion == TipoTransaccion.Insertar)
            {
                if (GuardarTipoInstrumento())
                {
                    Notificaciones.MensajeConfirmacion("¡El tipo de instrumento se ha registrado exitosamente!");
                    OnTipoInstrumentoAgregado?.Invoke(NuevoTipoInstrumento);
                    this.Close();
                }
            }
            else
            {
                if (ActualizarTipoInstrumento())
                {
                    Notificaciones.MensajeConfirmacion("¡El tipo de instrumento se ha actualizado exitosamente!");
                    OnTipoInstrumentoModificado?.Invoke(NuevoTipoInstrumento);
                    this.Close();
                }
            }

            SplashScreenManager.CloseForm();

        }

        private bool GuardarTipoInstrumento()
        {

            try
            {
                var resultado = _tipoInstrumentoService.RegistrarTipoInstrumento(NuevoTipoInstrumento);
                if (resultado.Type != TypeResponse.Ok) return false;

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private bool ActualizarTipoInstrumento()
        {

            try
            {
                var resultado = _tipoInstrumentoService.ActualizarTipoDeInstrumento(NuevoTipoInstrumento);
                if (resultado.Type != TypeResponse.Ok) return false;

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void PrepararNuevoTipoInstrumento()
        {
            NuevoTipoInstrumento.Descripcion = txtDescripcion.Text;
            NuevoTipoInstrumento.Metodologia = txtMetodologia.Text;
            NuevoTipoInstrumento.Resumen = txtResumen.Text;
        }


        private bool EsValidaLaInformacionIngresadaParaNuevoTipoInstrumento(out string mensaje)
        {
            if (string.IsNullOrEmpty(NuevoTipoInstrumento.Descripcion))
            {
                mensaje = "Es necesario ingresar una descripción para el tipo de instrumento.";
                return false;
            }

            if (string.IsNullOrEmpty(NuevoTipoInstrumento.Resumen))
            {
                mensaje = "Es necesario ingresar un resumen para el tipo de instrumento.";
                return false;
            }

            if (string.IsNullOrEmpty(NuevoTipoInstrumento.Metodologia))
            {
                mensaje = "Es necesario ingresar una metodología para el tipo de instrumento.";
                return false;
            }

            mensaje = "Ok";
            return true;
        }
    }
}