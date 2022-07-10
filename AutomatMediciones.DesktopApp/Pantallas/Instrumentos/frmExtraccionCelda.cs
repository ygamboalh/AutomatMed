using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;

namespace AutomatMediciones.DesktopApp.Pantallas.Instrumentos
{
    public partial class frmExtraccionCelda : DevExpress.XtraEditors.XtraForm
    {
        private readonly InstrumentoService _instrumentoService;

        public frmExtraccionCelda(InstrumentoService instrumentoService)
        {
            InitializeComponent();
            _instrumentoService = instrumentoService;
        }

        public CeldaInstrumentoDto CeldaInstrumento { get; set; }

        private void btnGuardarExtraccion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dateFechaExtraccion.Text))
            {
                Notificaciones.MensajeAdvertencia("Es necesario que seleccione una fecha de extracción.");
                return;
            }

            CeldaInstrumento.FechaExtraccion = (DateTime)dateFechaExtraccion.EditValue;
            var respuesta = _instrumentoService.DesactivarInstrumentoCelda(CeldaInstrumento);

            if (respuesta.Type != TypeResponse.Ok)
            {
                Notificaciones.MensajeError(respuesta.Message);
                return;
            }

            Notificaciones.MensajeConfirmacion("¡La extracción se guardó exitosamente!");
        }
    }
}