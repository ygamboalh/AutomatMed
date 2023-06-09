﻿using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.CertificadosDeCalibracion.Dtos;
using AutomatMediciones.DesktopApp.Reportes;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Core.Extentions.Enumeradores;
using Nagaira.Core.Extentions.Exceptions;
using Nagaira.Core.Extentions.Responses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.CertificadosDeCalibracion
{
    public partial class frmCertificadosDeCalibracion : DevExpress.XtraEditors.XtraForm
    {
        private ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private CertificadoCalibracionService _certificadoCalibracionService;

        public List<CertificadoDto> Certificados { get; set; }
        public int InstrumentoId { get; set; }
        public frmCertificadosDeCalibracion(CertificadoCalibracionService certificadoCalibracionService)
        {
            InitializeComponent();

            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonExportarExcel();
            btnVerCertificado.Click += btnVerCertificado_Click;
            btnEditar.Click += btnEditar_Click;
            btnVerCertificadoOriginal.Click += btnVerCertificadoOriginalClick;

            _certificadoCalibracionService = certificadoCalibracionService;

            CargarCertificadosDeCalibracion();
        }

        private void btnVerCertificadoOriginalClick(object sender, EventArgs e)
        {
            var certificadoSeleccionado = gvCertificados.GetFocusedRow() as CertificadoDto;
            if (certificadoSeleccionado == null) return;

            if (string.IsNullOrEmpty(certificadoSeleccionado.RutaCertificado))
            {
                Notificaciones.MensajeAdvertencia("Este certificado no está guardado en un directorio.");
                return;
            }

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));
            var frm = new frmVisualizadorPdf(certificadoSeleccionado.RutaCertificado);
            frm.Show();
            SplashScreenManager.CloseForm();


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var certificadoSeleccionado = gvCertificados.GetFocusedRow() as CertificadoDto;
            if (certificadoSeleccionado == null) return;

            var frmCertificadoCalibracion = new frmNuevoCertificadoCalibracion(TipoTransaccion.Actualizar, certificadoSeleccionado.InstrumentoId,
                serviceProvider.GetService<CertificadoCalibracionService>(),
                 serviceProvider.GetService<UsuarioService>(),
                 serviceProvider.GetService<PatronService>(),
                 serviceProvider.GetService<InstrumentoService>());
            frmCertificadoCalibracion.Certificado = certificadoSeleccionado;
            frmCertificadoCalibracion.OnCertificadoActualizado += frmCertificadoCalibracionCertificadoActualizado;
            frmCertificadoCalibracion.SetearValoresParaActualizar();
            frmCertificadoCalibracion.ShowDialog();
        }

        private void frmCertificadoCalibracionCertificadoActualizado(CertificadoDto certificado)
        {
            serviceProvider = Program.services.BuildServiceProvider();
            _certificadoCalibracionService = serviceProvider.GetService<CertificadoCalibracionService>();

            CargarCertificadosDeCalibracion();
        }

        private void btnVerCertificado_Click(object sender, EventArgs e)
        {
            var certificadoSeleccionado = gvCertificados.GetFocusedRow() as CertificadoDto;
            if (certificadoSeleccionado == null) return;

            SplashScreenManager.ShowForm(typeof(frmSaving));

            rptCertificadoCalibracion report1 = new rptCertificadoCalibracion(serviceProvider.GetService<PatronService>(), serviceProvider.GetService<CertificadoCalibracionService>(),
                serviceProvider.GetService<InstrumentoService>(), serviceProvider.GetService<VariableMedicionService>());

            report1.xrPictureBox2.ImageUrl = certificadoSeleccionado.Responsable.EnlaceFirmaDigital;
            report1.PrepararCertificado(certificadoSeleccionado);
            report1.CreateDocument();
            ReportPrintTool printTool = new ReportPrintTool(report1);
            printTool.ShowRibbonPreview();

            SplashScreenManager.CloseForm();
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {Certificados.Count}";
            lblTotal.Visible = true;
        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Certificados de Calibración";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }

        private void CargarCertificadosDeCalibracion()
        {
            var resultado = _certificadoCalibracionService.ObtenerCertificados();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var lista = new List<CertificadoView>();

            resultado.Data.ForEach(x =>
            {
                var certificadoView = new CertificadoView
                {
                    CertificadoId = x.CertificadoId,
                    CondicionesAmbientales = x.CondicionesAmbientales,
                    Fecha = x.Fecha,
                    FechaCaducidad = x.FechaCaducidad,
                    Instrumento = x.Instrumento,
                    InstrumentoId = x.InstrumentoId,
                    NumeroCertificado = x.NumeroCertificado,
                    Responsable = x.Responsable,
                    ResponsableId = x.ResponsableId,
                    ClasificacionConcatenada = $"{x.Instrumento.Clasificacion.TipoInstrumento.Descripcion}/{x.Instrumento.Clasificacion.Marca.Descripcion}/{x.Instrumento.Clasificacion.Modelo.Descripcion}",
                    VariablesCertificado = x.VariablesCertificado,
                    Observaciones = x.Observaciones,
                    Resultado = x.Resultado,
                    RutaCertificado = x.RutaCertificado
                };
                lista.Add(certificadoView);
            });



            Certificados = resultado.Data;

            gcCertificados.DataSource = lista;
            gcCertificados.RefreshDataSource();


            SetearTotales();
        }

        public void CargarCertificadosDeCalibracionPorInstrumento()
        {
            var resultado = _certificadoCalibracionService.ObtenerCertificadosPorInstrumento(InstrumentoId);
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var lista = new List<CertificadoView>();

            resultado.Data.ForEach(x =>
            {
                var certificadoView = new CertificadoView
                {
                    CertificadoId = x.CertificadoId,
                    CondicionesAmbientales = x.CondicionesAmbientales,
                    Fecha = x.Fecha,
                    FechaCaducidad = x.FechaCaducidad,
                    Instrumento = x.Instrumento,
                    InstrumentoId = x.InstrumentoId,
                    NumeroCertificado = x.NumeroCertificado,
                    Responsable = x.Responsable,
                    ResponsableId = x.ResponsableId,
                    ClasificacionConcatenada = $"{x.Instrumento.Clasificacion.TipoInstrumento.Descripcion}/{x.Instrumento.Clasificacion.Marca.Descripcion}/{x.Instrumento.Clasificacion.Modelo.Descripcion}",
                    VariablesCertificado = x.VariablesCertificado,
                    Observaciones = x.Observaciones,
                    Resultado = x.Resultado
                };
                lista.Add(certificadoView);
            });



            Certificados = resultado.Data;

            gcCertificados.DataSource = lista;
            gcCertificados.RefreshDataSource();


            SetearTotales();
        }


        private void EstablecerColorBotonExportarExcel()
        {
            btnExportarExcel.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnExportarExcel.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnExportarExcel.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var nombreArchivo = "Listado de Certificados";
            var filter = "Archivo de Microsoft Excel (*.xlsx)|*.xlsx";

            saveFileDialog.Filter = filter;
            saveFileDialog.FileName = nombreArchivo;

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                nombreArchivo = saveFileDialog.FileName;

                colVerCertificado.Visible = false;


                gcCertificados.ExportToXlsx(nombreArchivo);
                if (Notificaciones.PreguntaConfirmacion($"Archivo Guardado en: {nombreArchivo} ¿Desea abrir el archivo?") == System.Windows.Forms.DialogResult.Yes)
                {
                    FileHelper.AbrirArchivo(nombreArchivo);
                }
                SplashScreenManager.CloseForm();


                colVerCertificado.Visible = true;
            }
            else
            {
                SplashScreenManager.CloseForm();
            }
        }
    }


}