﻿using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Core.Extentions.Enumeradores;
using Nagaira.Core.Extentions.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.TiposDeInstrumento
{
    public partial class frmTiposDeInstrumento : DevExpress.XtraEditors.XtraForm
    {
        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private readonly TipoDeInstrumentoService _tipoInstrumentoService;

        ICollection<TipoInstrumentoDto> tiposInstrumento = new List<TipoInstrumentoDto>();

        public frmTiposDeInstrumento(TipoDeInstrumentoService tipoInstrumentoService)
        {
            InitializeComponent();

            _tipoInstrumentoService = tipoInstrumentoService;

            EstablecerNombreYTitulo();
            EstablecerColorBotonPorDefecto();
            CargarTiposDeInstrumentos();
            EstablecerColorBotonExportarExcel();

            repositoryItemButtonEdit1.Click += onSeleccionaTipoInstrumentoParaEditar;

        }


        private void EstablecerColorBotonExportarExcel()
        {
            btnExportarExcel.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnExportarExcel.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnExportarExcel.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void onSeleccionaTipoInstrumentoParaEditar(object sender, EventArgs e)
        {
            var tipoInstrumento = gvTipoInstrumento.GetFocusedRow() as TipoInstrumentoDto;

            if (tiposInstrumento == null) return;

            var frmTipoInstrumento = new frmNuevoTipoInstrumento(TipoTransaccion.Actualizar, serviceProvider.GetService<TipoDeInstrumentoService>());
            frmTipoInstrumento.NuevoTipoInstrumento = tipoInstrumento;
            frmTipoInstrumento.SetearValoresParaActualizar();
            frmTipoInstrumento.OnTipoInstrumentoModificado += OnTipoInstrumentoModificado;
            frmTipoInstrumento.ShowDialog();
        }

        private void OnTipoInstrumentoModificado(TipoInstrumentoDto tipoInstrumento)
        {
            tiposInstrumento = tiposInstrumento.Where(x => x.TipoInstrumentoId != tipoInstrumento.TipoInstrumentoId).ToList();
            tiposInstrumento.Add(tipoInstrumento);

            gcTipoInstrumento.DataSource = tiposInstrumento;
            gcTipoInstrumento.RefreshDataSource();

            SetearTotales();
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {tiposInstrumento.Count}";
            lblTotal.Visible = true;
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Tipos de Instrumento";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonPorDefecto()
        {
            btnAgregarNuevInstrumento.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnAgregarNuevInstrumento.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarNuevInstrumento.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }


        private void CargarTiposDeInstrumentos()
        {
            var resultado = _tipoInstrumentoService.ObtenerTiposDeInstrumento();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            tiposInstrumento = resultado.Data;
            gcTipoInstrumento.DataSource = tiposInstrumento;

            SetearTotales();
        }

        private void btnAgregarNuevInstrumento_Click(object sender, System.EventArgs e)
        {
            var frmTipoInstrumento = new frmNuevoTipoInstrumento(TipoTransaccion.Insertar, serviceProvider.GetService<TipoDeInstrumentoService>());
            frmTipoInstrumento.OnTipoInstrumentoAgregado += OnTipoInstrumentoAgregado;
            frmTipoInstrumento.ShowDialog();
        }

        private void OnTipoInstrumentoAgregado(TipoInstrumentoDto tipoInstrumento)
        {
            tiposInstrumento.Add(tipoInstrumento);
            gcTipoInstrumento.DataSource = tipoInstrumento;
            gcTipoInstrumento.RefreshDataSource();

            SetearTotales();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var nombreArchivo = "Listado Tipos de Instrumentos";
            var filter = "Archivo de Microsoft Excel (*.xlsx)|*.xlsx";

            saveFileDialog.Filter = filter;
            saveFileDialog.FileName = nombreArchivo;

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                nombreArchivo = saveFileDialog.FileName;


                colEditar.Visible = false;

                gcTipoInstrumento.ExportToXlsx(nombreArchivo);
                if (Notificaciones.PreguntaConfirmacion($"Archivo Guardado en: {nombreArchivo} ¿Desea abrir el archivo?") == System.Windows.Forms.DialogResult.Yes)
                {
                    FileHelper.AbrirArchivo(nombreArchivo);
                }
                SplashScreenManager.CloseForm();


                colEditar.Visible = true;
            }
            else
            {
                SplashScreenManager.CloseForm();
            }
        }
    }
}