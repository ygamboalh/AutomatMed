﻿using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Reportes;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Responses;
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
        public CertificadoDto Certificado { get; set; }

        UsuarioDto usuarioSeleccionado;
        PatronDto patronSeleccionado;
        VariableInstrumentoDto variableInstrumentoSeleccionado;

        private readonly CertificadoCalibracionService _certificadoCalibracionService;
        private readonly UsuarioService _usuarioService;
        private readonly PatronService _patronService;
        private readonly InstrumentoService _instrumentoService;

        List<VariableInstrumentoDto> variablesInstrumentos = new List<VariableInstrumentoDto>();

        List<VariableCertificadoDto> variablesCertificado;

        public frmNuevoCertificadoCalibracion(int instrumentoId, CertificadoCalibracionService certificadoCalibracionService, UsuarioService usuarioService,
            PatronService patronService, InstrumentoService instrumentoService)
        {
            InitializeComponent();

            _certificadoCalibracionService = certificadoCalibracionService;
            _usuarioService = usuarioService;
            _patronService = patronService;
            _instrumentoService = instrumentoService;

            Certificado = new CertificadoDto();
            Certificado.InstrumentoId = instrumentoId;

            variablesCertificado = new List<VariableCertificadoDto>();

            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonGuardar();
            CargarUsuarios();
            CargarPatrones();
            CargarVariablesInstrumentos();

            btnEliminar.Click += btnEliminarClick;
        }

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

            var usuarios = resultado.Data;

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

            Certificado.CondicionesAmbientales = memoCondicionesAmbientales.Text;
            Certificado.FechaCaducidad = dateFechaCaducidad.Value;
            Certificado.Fecha = dateFechaCertificado.Value;
            Certificado.ResponsableId = usuarioSeleccionado.UsuarioId;
            Certificado.VariablesCertificado = variablesCertificado;
            Certificado.Resultado = memoResultado.Text;
            Certificado.Observaciones = memoObservaciones.Text;

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
                rptCertificadoCalibracion reporteCertificado = new rptCertificadoCalibracion();
                reporteCertificado.xrPictureBox2.ImageUrl = Certificado.Responsable.EnlaceFirmaDigital;
                reporteCertificado.PrepararCertificado(Certificado);
                ReportPrintTool printTool = new ReportPrintTool(reporteCertificado);
                printTool.ShowRibbonPreview();
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
    }
}