using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Reportes;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.CertificadosDeCalibracion
{
    public partial class frmNuevoCertificadoCalibracion : DevExpress.XtraEditors.XtraForm
    {
        public frmNuevoCertificadoCalibracion()
        {
            InitializeComponent();
            EstablecerNombreYTituloPopupAgregarInstrumentos();
        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Nuevo Certificado";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }

        private void btnGenerarCertificado_Click(object sender, EventArgs e)
        {
            Notificaciones.MensajeConfirmacion("¡El certificado se generó exitosamente!");
            rptCertificadoDeCalibracion reporteIngreso = new rptCertificadoDeCalibracion();
       
            ReportPrintTool printTool = new ReportPrintTool(reporteIngreso);
            printTool.ShowRibbonPreview();
        }
    }
}