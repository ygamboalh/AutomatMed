using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Nagaira.Core.Extentions.Enumeradores;
using Nagaira.Core.Extentions.Responses;
using System;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Usuarios
{
    public partial class frmNuevoUsuario : DevExpress.XtraEditors.XtraForm
    {
        private readonly UsuarioService _usuarioService;

        public delegate void UsuarioAgregado(UsuarioDto usuario);
        public event UsuarioAgregado OnUsuarioAgregado;

        public TipoTransaccion TipoTransaccion { get; set; }
        public UsuarioDto NuevoUsuario { get; set; }

        public frmNuevoUsuario(TipoTransaccion tipoTransaccion, UsuarioService usuarioService)
        {
            InitializeComponent();

            TipoTransaccion = tipoTransaccion;

            NuevoUsuario = new UsuarioDto();
            _usuarioService = usuarioService;

            EstablecerNombreTitulo();
            EstablecerColorBotonGuardar();
        }

        public void SetearValoresParaActualizar()
        {
            txtCorreoUsuario.Text = NuevoUsuario.Correo;
            txtNombreUsuario.Text = NuevoUsuario.Nombre;
            txtRutaArchivo.Text = NuevoUsuario.EnlaceFirmaDigital;
        }

        private void EstablecerNombreTitulo()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = TipoTransaccion == TipoTransaccion.Insertar ? "Agregar Usuario" : "Modificar Usuario";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarUsuario.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarUsuario.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarUsuario.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void PrepararNuevoUsuario()
        {
            NuevoUsuario.Nombre = txtNombreUsuario.Text;
            NuevoUsuario.Correo = txtCorreoUsuario.Text;
            NuevoUsuario.EnlaceFirmaDigital = txtRutaArchivo.Text;
        }

        private bool EsValidaLaInformacionIngresadaParaNuevoPatron(out string mensaje)
        {
            if (string.IsNullOrEmpty(NuevoUsuario.Nombre))
            {
                mensaje = "Es necesario ingresar un nombre para el usuario.";
                return false;
            }

            mensaje = "Ok";
            return true;
        }

        private bool GuardarUsuarios()
        {
            try
            {
                var resultado = _usuarioService.RegistrarUsuario(NuevoUsuario);
                if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private bool ActualizarUsuario()
        {
            try
            {
                var resultado = _usuarioService.ActualizarUsuario(NuevoUsuario);
                if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }


        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            PrepararNuevoUsuario();
            if (!EsValidaLaInformacionIngresadaParaNuevoPatron(out string mensaje))
            {
                Notificaciones.MensajeAdvertencia(mensaje);
                return;
            }

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));
            if (TipoTransaccion == TipoTransaccion.Insertar)
            {
                if (GuardarUsuarios())
                {
                    Notificaciones.MensajeConfirmacion("¡El usuario se ha registrado exitosamente!");
                    OnUsuarioAgregado?.Invoke(NuevoUsuario);
                    this.Close();
                }

            }
            else
            {
                if (ActualizarUsuario())
                {
                    Notificaciones.MensajeConfirmacion("¡El usuario se ha actualizado exitosamente!");
                    OnUsuarioAgregado?.Invoke(NuevoUsuario);
                    this.Close();
                }
            }

            SplashScreenManager.CloseForm();
        }

        private void btnAdjunto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String path = dialog.FileName;
                txtRutaArchivo.Text = path;
            }
        }
    }
}