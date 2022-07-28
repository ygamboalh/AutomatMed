using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;

namespace AutomatMediciones.DesktopApp.Pantallas.TiposDeCelda
{
    public partial class frmTiposDeCelda : DevExpress.XtraEditors.XtraForm
    {
        private CeldaService _celdaService;
        private ServiceProvider serviceProvider = Program.services.BuildServiceProvider();

        ICollection<TipoCeldaDto> tiposDeCelda = new List<TipoCeldaDto>();
        public frmTiposDeCelda(CeldaService celdaService)
        {
            InitializeComponent();
            _celdaService = celdaService;

            EstablecerNombreYTitulo();
            EstablecerColorBotonExportarExcel();
            CargarTiposDeCelda();

            EstablecerColorBotonPorDefecto();

            btnEditar.Click += cmdEditarClick;
        }

        private void cmdEditarClick(object sender, EventArgs e)
        {

            var tipoCeldaSeleccionado = gvTipoDeCelda.GetFocusedRow() as TipoCeldaDto;

            var frmNuevoTipoCelda = new frmNuevoTIpoCelda(TipoTransaccion.Actualizar, serviceProvider.GetService<CeldaService>(),
                 serviceProvider.GetService<VariableMedicionService>());
            frmNuevoTipoCelda.OnTipoCeldaAgregada += OnTipoCeldaAgregada;
            frmNuevoTipoCelda.NuevoTipoCelda = tipoCeldaSeleccionado;
            frmNuevoTipoCelda.SetearValoresParaActualizar();
            frmNuevoTipoCelda.ShowDialog();
        }

        private void OnTipoCeldaAgregada(TipoCeldaDto tipoCelda)
        {
            serviceProvider = Program.services.BuildServiceProvider();
            _celdaService = serviceProvider.GetService<CeldaService>();
            CargarTiposDeCelda();
        }

        private void EstablecerColorBotonPorDefecto()
        {
            btnNuevoTipoDeCelda.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnNuevoTipoDeCelda.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnNuevoTipoDeCelda.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }


        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = System.Windows.Forms.DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Tipos de Celda";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }

        private void CargarTiposDeCelda()
        {
            var resultado = _celdaService.ObtenerTiposDeCeldas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var patronesRespuesta = resultado.Data;
            tiposDeCelda = patronesRespuesta;

            gcTiposDeCelda.DataSource = tiposDeCelda;

            SetearTotales();
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {tiposDeCelda.Count}";
            lblTotal.Visible = true;
        }

        private void EstablecerColorBotonExportarExcel()
        {
            btnExportarExcel.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnExportarExcel.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnExportarExcel.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void btnNuevoTipoDeCelda_Click(object sender, EventArgs e)
        {
            var frmNuevoTipoCelda = new frmNuevoTIpoCelda(TipoTransaccion.Insertar, serviceProvider.GetService<CeldaService>(),
               serviceProvider.GetService<VariableMedicionService>());
            frmNuevoTipoCelda.OnTipoCeldaAgregada += OnTipoCeldaAgregada;
            frmNuevoTipoCelda.ShowDialog();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var nombreArchivo = "Listado Tipos de Celda";
            var filter = "Archivo de Microsoft Excel (*.xlsx)|*.xlsx";

            saveFileDialog.Filter = filter;
            saveFileDialog.FileName = nombreArchivo;

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                nombreArchivo = saveFileDialog.FileName;

                colEditar.Visible = false;


                gcTiposDeCelda.ExportToXlsx(nombreArchivo);
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