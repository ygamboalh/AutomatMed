using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Reportes;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
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

namespace AutomatMediciones.DesktopApp.Pantallas.CertificadosDeCalibracion
{
    public partial class frmNuevoCertificadoCalibracion : DevExpress.XtraEditors.XtraForm
    {
        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        public CertificadoDto Certificado { get; set; }

        UsuarioDto usuarioSeleccionado;
        private readonly CertificadoCalibracionService _certificadoCalibracionService;
        private readonly UsuarioService _usuarioService;

        public frmNuevoCertificadoCalibracion(int instrumentoId, CertificadoCalibracionService certificadoCalibracionService, UsuarioService usuarioService)
        {
            InitializeComponent();


            _certificadoCalibracionService = certificadoCalibracionService;
            _usuarioService = usuarioService;
            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonGuardar();
            CargarUsuarios();

            Certificado = new CertificadoDto();
            Certificado.InstrumentoId = instrumentoId;

           
        }

        private void CargarUsuarios()
        {
            var resultado = _usuarioService.ObtenerUsuariosActivos();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var usuarios = resultado.Data;

            glUsuariosResponsables.Properties.DataSource = usuarios;
            glUsuariosResponsables.Properties.DisplayMember = "Nombre";
            glUsuariosResponsables.Properties.ValueMember = "UsuarioId";
        }

        private void EstablecerColorBotonGuardar()
        {
            btnGenerarCertificado.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGenerarCertificado.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGenerarCertificado.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
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

        private bool PrepararCertificado()
        {
            if (usuarioSeleccionado == null)
            {
                Notificaciones.MensajeAdvertencia("¡Es necesario que seleccione un usuario responsable!");
                return false;
            }

            Certificado.CondicionesAmbientales = memoCondicionesAmbientales.Text;
            Certificado.FechaCaducidad = dateFechaCaducidad.Value;
            Certificado.Fecha = dateFechaCertificado.Value;
            Certificado.ResponsableId = usuarioSeleccionado.UsuarioId;

            return true;
        }


        private bool GuardarCertificadoCalibracion()
        {

            try
            {
                var resultado = _certificadoCalibracionService.RegistrarCertificado(Certificado);
                if (resultado.Type != TypeResponse.Ok)
                {
                   
                    Notificaciones.MensajeError(resultado.Message);
                           
                  
                    return false;

                }

                Certificado = resultado.Data;

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void btnGenerarCertificado_Click(object sender, EventArgs e)
        {
            if (!PrepararCertificado()) return;

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));

            if (GuardarCertificadoCalibracion())
            {
                Notificaciones.MensajeConfirmacion("¡El certificado se generó exitosamente!");
                rptCertificadoDeCalibracion reporteCertificado = new rptCertificadoDeCalibracion();
                reporteCertificado.objectDataSource1.DataSource = Certificado;

                ReportPrintTool printTool = new ReportPrintTool(reporteCertificado);
                printTool.ShowRibbonPreview();
            }
            
     
            SplashScreenManager.CloseForm();

          
        }

        private void frmNuevoCertificadoCalibracion_Load(object sender, EventArgs e)
        {

        }

        private void glUsuariosResponsables_EditValueChanged(object sender, EventArgs e)
        {
            usuarioSeleccionado = glUsuariosResponsablesView.GetFocusedRow() as UsuarioDto;
        }
    }
}