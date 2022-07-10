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

namespace AutomatMediciones.DesktopApp.Pantallas.Usuarios
{
    public partial class frmUsuarios : DevExpress.XtraEditors.XtraForm
    {
        private UsuarioService _usuarioService;
        private ServiceProvider serviceProvider = Program.services.BuildServiceProvider();

        ICollection<UsuarioDto> usuarios = new List<UsuarioDto>();
        public frmUsuarios(UsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;

            EstablecerColorBotonExportarExcel();
            EstablecerColorBotonPorDefecto();

            EstablecerNombreYTitulo();

            CargarUsuarios();

            cmdVerFirmaDigtal.Click += cmdVerFirmaDigtalClick;
            cmdEditarUsuario.Click += cmdEditarUsuarioClick;
        }

        private void cmdEditarUsuarioClick(object sender, EventArgs e)
        {
            var usuarioSeleccionado = gvUsuarios.GetFocusedRow() as UsuarioDto;

            var frmNuevoUsuario = new frmNuevoUsuario(TipoTransaccion.Actualizar, serviceProvider.GetService<UsuarioService>());
            frmNuevoUsuario.OnUsuarioAgregado += OnUsuarioAgregado;
            frmNuevoUsuario.NuevoUsuario = usuarioSeleccionado;
            frmNuevoUsuario.SetearValoresParaActualizar();
            frmNuevoUsuario.ShowDialog();
        }

        private void OnUsuarioAgregado(UsuarioDto usuario)
        {
            serviceProvider = Program.services.BuildServiceProvider();
            _usuarioService = serviceProvider.GetService<UsuarioService>();
            CargarUsuarios();
        }

        private void cmdVerFirmaDigtalClick(object sender, EventArgs e)
        {
            var usuarioSeleccionado = gvUsuarios.GetFocusedRow() as UsuarioDto;
            if (usuarioSeleccionado == null) return;

            if (string.IsNullOrEmpty(usuarioSeleccionado.EnlaceFirmaDigital))
            {
                Notificaciones.MensajeAdvertencia("Este usuario no tiene asignada una firma digital.");
                return;
            }

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));
            var frm = new frmVisualizadorImagen(usuarioSeleccionado.EnlaceFirmaDigital);
            frm.Show();
            SplashScreenManager.CloseForm();

        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = System.Windows.Forms.DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Usuarios";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }


        private void EstablecerColorBotonPorDefecto()
        {
            btnAgregarUsuario.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnAgregarUsuario.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarUsuario.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void EstablecerColorBotonExportarExcel()
        {
            btnExportarExcel.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnExportarExcel.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnExportarExcel.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }


        private void CargarUsuarios()
        {

            var resultado = _usuarioService.ObtenerTodosLosUsuarios();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var patronesRespuesta = resultado.Data;
            usuarios = patronesRespuesta;

            gcUsuarios.DataSource = usuarios;
            gcUsuarios.RefreshDataSource();

            SetearTotales();
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {usuarios.Count}";
            lblTotal.Visible = true;
        }


        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            var frmNuevoUsuario = new frmNuevoUsuario(TipoTransaccion.Insertar, serviceProvider.GetService<UsuarioService>());
            frmNuevoUsuario.OnUsuarioAgregado += OnUsuarioAgregado;
            frmNuevoUsuario.ShowDialog();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var nombreArchivo = "Listado de Usuarios";
            var filter = "Archivo de Microsoft Excel (*.xlsx)|*.xlsx";

            saveFileDialog.Filter = filter;
            saveFileDialog.FileName = nombreArchivo;

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                nombreArchivo = saveFileDialog.FileName;

                colEditarUsuario.Visible = false;
                colVerFirmaDigital.Visible = false;


                gcUsuarios.ExportToXlsx(nombreArchivo);
                if (Notificaciones.PreguntaConfirmacion($"Archivo Guardado en: {nombreArchivo} ¿Desea abrir el archivo?") == System.Windows.Forms.DialogResult.Yes)
                {
                    FileHelper.AbrirArchivo(nombreArchivo);
                }
                SplashScreenManager.CloseForm();

                colEditarUsuario.Visible = true;
                colVerFirmaDigital.Visible = true;
            }
            else
            {
                SplashScreenManager.CloseForm();
            }
        }
    }
}