﻿using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Instrumentos
{
    public partial class frmInstrumentoVariable : DevExpress.XtraEditors.XtraForm
    {
        public delegate void VariableInstrumentoAgregada(VariableInstrumentoDto variableInstrumentoDto);
        public event VariableInstrumentoAgregada OnVariableInstrumentoAgregado;

        public delegate void VariableInstrumentoActualizada(VariableInstrumentoDto variableInstrumentoDto);
        public event VariableInstrumentoActualizada OnVariableInstrumentoActualizada;


        private readonly InstrumentoService _instrumentoService;
        private readonly VariableMedicionService _variableMedicionService;
        private readonly TipoTransaccion _tipoTransaccion;

        public VariableInstrumentoDto NuevaVariableInstrumento { get; set; }

        VariableMedicionDto variableDeMedicionSeleccionada;
        public int InstrumentoId { get; set; }

        public frmInstrumentoVariable(TipoTransaccion tipoTransaccion, InstrumentoService instrumentoService, VariableMedicionService variableMedicionService)
        {
            InitializeComponent();

            _tipoTransaccion = tipoTransaccion;
            _instrumentoService = instrumentoService;
            _variableMedicionService = variableMedicionService;

            NuevaVariableInstrumento = new VariableInstrumentoDto();

            EstablecerColorBotonGuardar();
            EstablecerNombreYTituloPopupAgregarInstrumentos();

            CargarVariablesDeMedicion();
        }

        public void SetearValoresParaActualizar()
        {
            glVariableDeMedicion.EditValue = NuevaVariableInstrumento.VariableMedicionId;
            nmAlarmaAlta.Value = NuevaVariableInstrumento.AlarmaAlta.Value;
            nmAlarmaBaja.Value = NuevaVariableInstrumento.AlarmaBaja.Value;
            nmAlarmaStel.Value = NuevaVariableInstrumento.AlarmaStel.Value;
            nmAlarmaTwa.Value = NuevaVariableInstrumento.AlarmaTwa.Value;
            InstrumentoId = NuevaVariableInstrumento.InstrumentoId;
        }

        private void EstablecerColorBotonGuardar()
        {
            btnGuardarVinculacion.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarVinculacion.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarVinculacion.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = _tipoTransaccion == TipoTransaccion.Insertar ? "Agregar vinculacíón de Variable Medición" : "Editar Vinculación";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }

        private void btnGuardarVinculacion_Click(object sender, EventArgs e)
        {
            if (!PrepararNuevaVinculacionDeVariable())
            {
                return;
            }

            if (_tipoTransaccion == TipoTransaccion.Insertar)
            {

                SplashScreenManager.ShowForm(typeof(frmLoadingSave));
                if (GuardarVinculacionVariableMedicion())
                {
                    Notificaciones.MensajeConfirmacion("¡La vinculación se ha registrado exitosamente!");
                    OnVariableInstrumentoAgregado?.Invoke(NuevaVariableInstrumento);
                    this.Close();
                }

                SplashScreenManager.CloseForm();
            }
            else
            {
                SplashScreenManager.ShowForm(typeof(frmLoadingSave));
                if (GuardarVinculacionVariableMedicion())
                {
                    Notificaciones.MensajeConfirmacion("¡La vinculación se actualizó exitosamente!");
                    OnVariableInstrumentoActualizada?.Invoke(NuevaVariableInstrumento);
                    this.Close();
                }

                SplashScreenManager.CloseForm();
            }
        }

        private void CargarVariablesDeMedicion()
        {
            var resultado = _variableMedicionService.ObtenerVariablesDeMedicionActivas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);


            glVariableDeMedicion.Properties.DataSource = resultado.Data;
            glVariableDeMedicion.Properties.ValueMember = "VariableMedicionId";
            glVariableDeMedicion.Properties.DisplayMember = "Descripcion";
        }

        private bool GuardarVinculacionVariableMedicion()
        {

            try
            {
                var resultado = _instrumentoService.GuardarVinculacionVariableDeMedicion(NuevaVariableInstrumento);
                if (resultado.Type != TypeResponse.Ok)
                {
                    Notificaciones.MensajeError(resultado.Message);
                    return false;
                }

                NuevaVariableInstrumento = resultado.Data;
                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private bool ActualizarVinculacionVariableMedicion()
        {

            try
            {
                var resultado = _instrumentoService.GuardarVinculacionVariableDeMedicion(NuevaVariableInstrumento);
                if (resultado.Type != TypeResponse.Ok)
                {
                    Notificaciones.MensajeError(resultado.Message);
                    return false;
                }

                NuevaVariableInstrumento = resultado.Data;
                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private bool PrepararNuevaVinculacionDeVariable()
        {
            if (variableDeMedicionSeleccionada == null)
            {
                Notificaciones.MensajeAdvertencia("Es necesario que seleccione una variable de medición.");
                return false;
            }

            NuevaVariableInstrumento.VariableMedicionId = variableDeMedicionSeleccionada.VariableMedicionId;
            NuevaVariableInstrumento.InstrumentoId = InstrumentoId;
            NuevaVariableInstrumento.TieneAlarma = toggleTieneAlarma.IsOn;
            NuevaVariableInstrumento.AlarmaAlta = nmAlarmaAlta.Value;
            NuevaVariableInstrumento.AlarmaBaja = nmAlarmaBaja.Value;
            NuevaVariableInstrumento.AlarmaStel = nmAlarmaStel.Value;
            NuevaVariableInstrumento.AlarmaTwa = nmAlarmaTwa.Value;

            return true;
        }

        private void glVariableDeMedicion_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }

        private void glVariableDeMedicion_EditValueChanged(object sender, EventArgs e)
        {
            variableDeMedicionSeleccionada = glVariableDeMedicion.GetSelectedDataRow() as VariableMedicionDto;
        }
    }
}