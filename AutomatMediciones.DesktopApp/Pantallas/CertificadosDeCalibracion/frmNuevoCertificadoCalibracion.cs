using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Reportes;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Core.Extentions.Enumeradores;
using Nagaira.Core.Extentions.Exceptions;
using Nagaira.Core.Extentions.Responses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.CertificadosDeCalibracion
{
    public partial class frmNuevoCertificadoCalibracion : DevExpress.XtraEditors.XtraForm
    {
        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();

        public delegate void CertificadoActualizado(CertificadoDto certificado);
        public event CertificadoActualizado OnCertificadoActualizado;
        public CertificadoDto Certificado { get; set; }
        public TipoTransaccion TipoTransaccion { get; set; }

        UsuarioDto usuarioSeleccionado;
        PatronDto patronSeleccionado;
        VariableInstrumentoDto variableInstrumentoSeleccionado;

        private readonly CertificadoCalibracionService _certificadoCalibracionService;
        private readonly UsuarioService _usuarioService;
        private readonly PatronService _patronService;
        private readonly InstrumentoService _instrumentoService;

        List<VariableInstrumentoDto> variablesInstrumentos = new List<VariableInstrumentoDto>();

        List<VariableCertificadoDto> variablesCertificado;

        public frmNuevoCertificadoCalibracion(TipoTransaccion tipoTransaccion, int instrumentoId, CertificadoCalibracionService certificadoCalibracionService, UsuarioService usuarioService,
            PatronService patronService, InstrumentoService instrumentoService)
        {
            InitializeComponent();
            TipoTransaccion = tipoTransaccion;
            _certificadoCalibracionService = certificadoCalibracionService;
            _usuarioService = usuarioService;
            _patronService = patronService;
            _instrumentoService = instrumentoService;

            Certificado = new CertificadoDto();
            Certificado.InstrumentoId = instrumentoId;

            usuarioSeleccionado = new UsuarioDto();

            variablesCertificado = new List<VariableCertificadoDto>();

            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonGuardar();
            CargarUsuarios();
            CargarPatrones();
            CargarVariablesInstrumentos();

            btnEliminar.Click += btnEliminarClick;
        }

        public void SetearValoresParaActualizar()
        {
            memoCondicionesAmbientales.Text = Certificado.CondicionesAmbientales;

            dateFechaCaducidad.Value = Certificado.FechaCaducidad;
            dateFechaCertificado.Value = Certificado.Fecha;

            variablesCertificado = Certificado.VariablesCertificado;
            memoResultado.Text = Certificado.Resultado;
            memoObservaciones.Text = Certificado.Observaciones;
            txtRutaArchivo.Text = Certificado.RutaCertificado;
            glUsuariosResponsables.EditValue = Certificado.ResponsableId;

            usuarioSeleccionado = usuarios.FirstOrDefault(x => x.UsuarioId == Certificado.ResponsableId);
            gcVariablesCertificado.DataSource = Certificado.VariablesCertificado;
            gcVariablesCertificado.RefreshDataSource();

            btnAdjunto.Visible = false;
            txtRutaArchivo.Visible = false;
            lblCertificado.Visible = false;
        }

        List<UsuarioDto> usuarios = new List<UsuarioDto>();
        private void btnEliminarClick(object sender, EventArgs e)
        {
            var filaSeleccionada = gvVariablesCertificado.GetFocusedRow() as VariableCertificadoDto;

            if (filaSeleccionada != null)
            {
                variablesCertificado = variablesCertificado.Where(x => x.VariableInstrumentoId != filaSeleccionada.VariableInstrumentoId && x.PatronId != filaSeleccionada.PatronId).ToList();
                gcVariablesCertificado.DataSource = variablesCertificado;
                gcVariablesCertificado.RefreshDataSource();
            }
        }

        private void CargarUsuarios()
        {
            var resultado = _usuarioService.ObtenerUsuariosActivos();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            usuarios = resultado.Data;

            glUsuariosResponsables.Properties.DataSource = usuarios;
            glUsuariosResponsables.Properties.DisplayMember = "Nombre";
            glUsuariosResponsables.Properties.ValueMember = "UsuarioId";
        }

        private void CargarVariablesInstrumentos()
        {
            var resultado = _instrumentoService.ObtenerVariablesInstrumentos(Certificado.InstrumentoId);
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            variablesInstrumentos = resultado.Data;

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

            if (string.IsNullOrEmpty(txtRutaArchivo.Text))
            {
                Notificaciones.MensajeAdvertencia("¡Es necesario que seleccione una ruta para guardar el certificado!");
                return false;
            }

            Certificado.CondicionesAmbientales = memoCondicionesAmbientales.Text;
            Certificado.FechaCaducidad = dateFechaCaducidad.Value;
            Certificado.Fecha = dateFechaCertificado.Value;
            Certificado.ResponsableId = usuarioSeleccionado.UsuarioId;
            Certificado.VariablesCertificado = variablesCertificado;
            Certificado.Resultado = memoResultado.Text;
            Certificado.Observaciones = memoObservaciones.Text;
            Certificado.RutaCertificado = txtRutaArchivo.Text;

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

        private bool ActualizarCertificadoDeCalibracion()
        {

            try
            {
                var resultado = _certificadoCalibracionService.ActualizarCertificado(Certificado);
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

            if (TipoTransaccion == TipoTransaccion.Insertar)
            {
                if (GuardarCertificadoCalibracion())
                {
                    Notificaciones.MensajeConfirmacion("¡El certificado se generó exitosamente!");
                    rptCertificadoCalibracion reporteCertificado = new rptCertificadoCalibracion(serviceProvider.GetService<PatronService>(), serviceProvider.GetService<CertificadoCalibracionService>(),
                    serviceProvider.GetService<InstrumentoService>(), serviceProvider.GetService<VariableMedicionService>());
                    reporteCertificado.xrPictureBox2.ImageUrl = Certificado.Responsable.EnlaceFirmaDigital;
                    reporteCertificado.PrepararCertificado(Certificado);
                    ReportPrintTool printTool = new ReportPrintTool(reporteCertificado);

                    // Specify export options.
                    PdfExportOptions pdfExportOptions = new PdfExportOptions()
                    {
                        PdfACompatibility = PdfACompatibility.PdfA1b
                    };

                    // Specify the path for the exported PDF file.  
                    string pdfExportFile = $"{txtRutaArchivo.Text}/{Certificado.CertificadoId}.pdf";


                    // Export the report.
                    reporteCertificado.ExportToPdf(pdfExportFile, pdfExportOptions);

                    printTool.ShowRibbonPreview();
                }
            }
            else
            {
                if (ActualizarCertificadoDeCalibracion())
                {
                    Notificaciones.MensajeConfirmacion("¡El certificado se actualizó exitosamente!");
                    OnCertificadoActualizado?.Invoke(Certificado);


                    rptCertificadoCalibracion reporteCertificado = new rptCertificadoCalibracion(serviceProvider.GetService<PatronService>(), serviceProvider.GetService<CertificadoCalibracionService>(),
                    serviceProvider.GetService<InstrumentoService>(), serviceProvider.GetService<VariableMedicionService>());
                    reporteCertificado.xrPictureBox2.ImageUrl = Certificado.Responsable.EnlaceFirmaDigital;
                    reporteCertificado.PrepararCertificado(Certificado);
                    ReportPrintTool printTool = new ReportPrintTool(reporteCertificado);
                    printTool.ShowRibbonPreview();
                }
            }


            SplashScreenManager.CloseForm();
        }

        private void CargarPatrones()
        {
            var resultado = _patronService.ObtenerPatrones();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var patronesRespuesta = resultado.Data;
            lookUpPatron.Properties.DataSource = patronesRespuesta;

            lookUpPatron.Properties.DisplayMember = "Nombre";
            lookUpPatron.Properties.ValueMember = "PatronId";
        }

        private void glUsuariosResponsables_EditValueChanged(object sender, EventArgs e)
        {
            usuarioSeleccionado = glUsuariosResponsablesView.GetFocusedRow() as UsuarioDto;
        }

        private void btnAgregarVariable_Click(object sender, EventArgs e)
        {
            if (patronSeleccionado == null)
            {
                Notificaciones.MensajeAdvertencia("Es necesario que seleccione un patrón.");
                return;
            }


            if (variableInstrumentoSeleccionado == null)
            {
                Notificaciones.MensajeAdvertencia("Es necesario que seleccione una variable.");
                return;
            }

            VariableCertificadoDto variableCertificadoDto = new VariableCertificadoDto
            {
                PatronId = patronSeleccionado.PatronId,
                VariableInstrumentoId = variableInstrumentoSeleccionado.VariableInstrumentoId,
                ValorMedido = nmValorMedido.Value,
                Patron = patronSeleccionado,
                VariableInstrumento = variableInstrumentoSeleccionado
            };

            if (!variablesCertificado.Any(x => x.PatronId == patronSeleccionado.PatronId && x.VariableInstrumentoId == variableInstrumentoSeleccionado.VariableInstrumentoId))
            {
                variablesCertificado.Add(variableCertificadoDto);
                gcVariablesCertificado.DataSource = variablesCertificado;
                gcVariablesCertificado.RefreshDataSource();
            }
            else
            {
                Notificaciones.MensajeAdvertencia("Este registro ya fue agregado a lista de variables.");
            }

        }

        private void glPatrones_EditValueChanged(object sender, EventArgs e)
        {
            lookupVariableDeInstrumento.Properties.DataSource = null;
            lookupVariableDeInstrumento.EditValue = "";

            patronSeleccionado = lookUpPatron.GetSelectedDataRow() as PatronDto;
            var variablesDeMedicion = patronSeleccionado.VariablesPatrones.Select(x => x.VariableDeMedicion).Select(x => x.VariableMedicionId);
            var nuevasVariables = variablesInstrumentos.Where(x => variablesDeMedicion.Contains(x.VariableMedicionId)).ToList();

            lookupVariableDeInstrumento.Properties.DataSource = nuevasVariables;
            lookupVariableDeInstrumento.Properties.DisplayMember = "VariableDeMedicion.Descripcion";
            lookupVariableDeInstrumento.Properties.ValueMember = "VariableInstrumentoId";
        }

        private void glVariableInstrumento_EditValueChanged(object sender, EventArgs e)
        {
            variableInstrumentoSeleccionado = lookupVariableDeInstrumento.GetSelectedDataRow() as VariableInstrumentoDto;
        }

        private void btnAdjunto_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();


            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtRutaArchivo.Text = fbd.SelectedPath;
            }
        }
    }
}