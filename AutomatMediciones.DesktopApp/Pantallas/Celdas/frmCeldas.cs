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
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Celdas
{
    public partial class frmCeldas : DevExpress.XtraEditors.XtraForm
    {

        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private readonly CeldaService _celdaService;
        ICollection<CeldaDto> celdas = new List<CeldaDto>();

        public frmCeldas(CeldaService celdaService)
        {
            InitializeComponent();
            _celdaService = celdaService;

            EstablecerNombreYTitulo();
            EstablecerColorBotonPorDefecto();
            EstablecerColorBotonExportarExcel();
            CargarCeldas();

            btnEditar.Click += btnEditarClick;
        }

        private void EstablecerColorBotonExportarExcel()
        {
            btnExportarExcel.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnExportarExcel.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnExportarExcel.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }



        private void btnEditarClick(object sender, EventArgs e)
        {
            var celda = gvCeldas
                .GetFocusedRow() as CeldaDto;
            if (celda == null) return;


            var frmNuevaCelda = new frmNuevaCelda(TipoTransaccion.Actualizar, serviceProvider.GetService<CeldaService>());
            frmNuevaCelda.NuevaCelda = celda;
            frmNuevaCelda.SetearValoresParaActualizar();
            frmNuevaCelda.OnCeldaModificada += OnCeldaModificada;
            frmNuevaCelda.ShowDialog();
        }

        private void OnCeldaModificada(CeldaDto celda)
        {
            celdas = celdas.Where(x => x.Id != celda.Id).ToList();
            celdas.Add(celda);

            gcCeldas.DataSource = celdas;
            gcCeldas.RefreshDataSource();

            SetearTotales();
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Celdas";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonPorDefecto()
        {
            btnAgregarNuevaCelda.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnAgregarNuevaCelda.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarNuevaCelda.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void CargarCeldas()
        {
            var resultado = _celdaService.ObtenerCeldas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var celdasRespuesta = resultado.Data;
            celdas = celdasRespuesta;

            gcCeldas.DataSource = celdas;

            SetearTotales();
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {celdas.Count}";
            lblTotal.Visible = true;
        }

        private void btnAgregarNuevaCelda_Click(object sender, EventArgs e)
        {
            var frmNuevaCelda = new frmNuevaCelda(TipoTransaccion.Insertar, serviceProvider.GetService<CeldaService>());
            frmNuevaCelda.OnCeldaAgregada += OnCeldaAgregada;
            frmNuevaCelda.ShowDialog();
        }

        private void OnCeldaAgregada(CeldaDto celda)
        {
            celdas.Add(celda);
            gcCeldas.DataSource = celdas;
            gcCeldas.RefreshDataSource();

            SetearTotales();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var nombreArchivo = "Listado de Celdas";
            var filter = "Archivo de Microsoft Excel (*.xlsx)|*.xlsx";

            saveFileDialog.Filter = filter;
            saveFileDialog.FileName = nombreArchivo;

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                nombreArchivo = saveFileDialog.FileName;

                colEditar.Visible = false;

                gcCeldas.ExportToXlsx(nombreArchivo);
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