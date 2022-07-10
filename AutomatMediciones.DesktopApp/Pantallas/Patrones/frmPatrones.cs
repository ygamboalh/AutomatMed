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

namespace AutomatMediciones.DesktopApp.Pantallas.Patrones
{
    public partial class frmPatrones : DevExpress.XtraEditors.XtraForm
    {
        private PatronService _patronService;
        private ServiceProvider serviceProvider = Program.services.BuildServiceProvider();


        ICollection<PatronDto> patrones = new List<PatronDto>();
        public frmPatrones(PatronService patronService)
        {
            InitializeComponent();
            _patronService = patronService;

            EstablecerNombreYTitulo();
            EstablecerColorBotonExportarExcel();
            CargarPatrones();

            cmdEditar.Click += cmdEditarPatroClick;
            cmdDesactivar.Click += cmdDesactivarPatronClick;
            cmdVerPatron.Click += cmdVerPatronClick;

            EstablecerColorBotonPorDefecto();
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = System.Windows.Forms.DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Patrones";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }

        private void cmdVerPatronClick(object sender, EventArgs e)
        {
            var patronSeleccionado = gvPatrones.GetFocusedRow() as PatronDto;
            if (patronSeleccionado == null) return;

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));
            var frm = new frmVisualizadorPdf(patronSeleccionado.Link);
            frm.Show();
            SplashScreenManager.CloseForm();

        }

        private void EstablecerColorBotonPorDefecto()
        {
            btnAgregarNuevoPatron.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnAgregarNuevoPatron.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarNuevoPatron.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void cmdDesactivarPatronClick(object sender, EventArgs e)
        {
            var patronSeleccionado = gvPatrones.GetFocusedRow() as PatronDto;

            if (patronSeleccionado == null) return;

            if (InactivarPatron(patronSeleccionado))
            {
                Notificaciones.MensajeConfirmacion("¡La desactivación del Patrón se ha realizado exitosamente!");
                patrones = patrones.Where(x => x.PatronId != patronSeleccionado.PatronId).ToList();
                gcPatrones.DataSource = patrones;
                gcPatrones.RefreshDataSource();
            }
        }

        private bool InactivarPatron(PatronDto patronDto)
        {
            try
            {
                var resultado = _patronService.DesactivarPatron(patronDto);
                if (resultado.Type != TypeResponse.Ok) return false;

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void cmdEditarPatroClick(object sender, EventArgs e)
        {
            var patronSeleccionado = gvPatrones.GetFocusedRow() as PatronDto;

            var frmNuevoPatron = new frmNuevoPatron(TipoTransaccion.Actualizar, serviceProvider.GetService<PatronService>(),
                 serviceProvider.GetService<VariableMedicionService>());
            frmNuevoPatron.OnPatronAgregado += OnPatronAgregado;
            frmNuevoPatron.NuevoPatron = patronSeleccionado;
            frmNuevoPatron.SetearValoresParaActualizar();
            frmNuevoPatron.ShowDialog();
        }

        private void CargarPatrones()
        {
            var resultado = _patronService.ObtenerPatrones();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var patronesRespuesta = resultado.Data;
            patrones = patronesRespuesta;

            gcPatrones.DataSource = patrones;

            SetearTotales();
        }

        private void EstablecerColorBotonExportarExcel()
        {
            btnExportarExcel.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnExportarExcel.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnExportarExcel.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {patrones.Count}";
            lblTotal.Visible = true;
        }

        private void btnAgregarNuevoPatron_Click(object sender, System.EventArgs e)
        {
            var frmNuevoPatron = new frmNuevoPatron(TipoTransaccion.Insertar, serviceProvider.GetService<PatronService>(),
                serviceProvider.GetService<VariableMedicionService>());
            frmNuevoPatron.OnPatronAgregado += OnPatronAgregado;
            frmNuevoPatron.ShowDialog();
        }

        private void OnPatronAgregado(PatronDto patron)
        {
            serviceProvider = Program.services.BuildServiceProvider();
            _patronService = serviceProvider.GetService<PatronService>();
            CargarPatrones();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var nombreArchivo = "Listado de Patrónes";
            var filter = "Archivo de Microsoft Excel (*.xlsx)|*.xlsx";

            saveFileDialog.Filter = filter;
            saveFileDialog.FileName = nombreArchivo;

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                nombreArchivo = saveFileDialog.FileName;

                colEditar.Visible = false;
                colDesactivar.Visible = false;
                colVerPatron.Visible = false;

                gcPatrones.ExportToXlsx(nombreArchivo);
                if (Notificaciones.PreguntaConfirmacion($"Archivo Guardado en: {nombreArchivo} ¿Desea abrir el archivo?") == System.Windows.Forms.DialogResult.Yes)
                {
                    FileHelper.AbrirArchivo(nombreArchivo);
                }
                SplashScreenManager.CloseForm();

                colEditar.Visible = true;
                colDesactivar.Visible = true;
                colVerPatron.Visible = true;
            }
            else
            {
                SplashScreenManager.CloseForm();
            }
        }
    }
}