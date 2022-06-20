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
using System.Linq;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Marcas
{
    public partial class frmMarcas : DevExpress.XtraEditors.XtraForm
    {

        ICollection<MarcaDto> marcas = new List<MarcaDto>();

        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private readonly MarcaService _marcaService;

        public frmMarcas(MarcaService marcaService)
        {
            InitializeComponent();
            _marcaService = marcaService;

            EstablecerNombreYTitulo();
            EstablecerColorBotonPorDefecto();
            EstablecerColorBotonExportarExcel();
            CargarMarcas();

            cmdEditar.Click += OnSeleccionaMarcaParaModificar;

        }


        private void OnSeleccionaMarcaParaModificar(object sender, EventArgs e)
        {
            var marca = gvMarcas.GetFocusedRow() as MarcaDto;
            if (marca == null) return;


            var frmNuevaMarca = new frmNuevaMarca(TipoTransaccion.Actualizar, serviceProvider.GetService<MarcaService>());
            frmNuevaMarca.NuevaMarca = marca;
            frmNuevaMarca.SetearValoresParaActualizar();
            frmNuevaMarca.OnMarcaModificada += OnMarcaModificada;
            frmNuevaMarca.ShowDialog();
        }

        private void OnMarcaModificada(MarcaDto marca)
        {
            marcas = marcas.Where(x => x.MarcaId != marca.MarcaId).ToList();
            marcas.Add(marca);

            gcMarcas.DataSource = marcas;
            gcMarcas.RefreshDataSource();

            SetearTotales();
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {marcas.Count}";
            lblTotal.Visible = true;
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Marcas";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonPorDefecto()
        {
            btnAgregarNuevInstrumento.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnAgregarNuevInstrumento.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarNuevInstrumento.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void CargarMarcas()
        {
            var resultado = _marcaService.ObtenerMarcas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var marcasRespuesta = resultado.Data;
            marcas = marcasRespuesta;

            gcMarcas.DataSource = marcas;

            SetearTotales();
        }

        private void btnAgregarNuevInstrumento_Click(object sender, System.EventArgs e)
        {

            var frmNuevaMarca = new frmNuevaMarca(TipoTransaccion.Insertar, serviceProvider.GetService<MarcaService>());
            frmNuevaMarca.OnMarcaAgregada += OnMarcaAgregada;
            frmNuevaMarca.ShowDialog();
        }

        private void OnMarcaAgregada(MarcaDto marca)
        {
            marcas.Add(marca);
            gcMarcas.DataSource = marcas;
            gcMarcas.RefreshDataSource();

            SetearTotales();
        }

        private void EstablecerColorBotonExportarExcel()
        {
            btnExportarExcel.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnExportarExcel.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnExportarExcel.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {

        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var nombreArchivo = "Listado de Marcas";
            var filter = "Archivo de Microsoft Excel (*.xlsx)|*.xlsx";

            saveFileDialog.Filter = filter;
            saveFileDialog.FileName = nombreArchivo;

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                nombreArchivo = saveFileDialog.FileName;

                colEditar.Visible = false;

                gcMarcas.ExportToXlsx(nombreArchivo);
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