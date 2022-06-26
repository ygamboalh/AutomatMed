using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraEditors;
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

            CeldaInstrumento.FechaExtraccion = (DateTime) dateFechaExtraccion.EditValue;
            _instrumentoService.DesactivarInstrumentoCelda(CeldaInstrumento)
        }
    }
}