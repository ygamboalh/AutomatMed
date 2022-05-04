using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Patrones
{
    public partial class frmNuevoPatron : DevExpress.XtraEditors.XtraForm
    {
        private readonly PatronService _patronService;

        public delegate void PatronAgregado(PatronDto patron);
        public event PatronAgregado OnPatronAgregado;

        public TipoTransaccion TipoTransaccion { get; set; }

        public PatronDto NuevoPatron { get; set; }

        public frmNuevoPatron(TipoTransaccion tipoTransaccion, PatronService patronService)
        {
            InitializeComponent();
            TipoTransaccion = tipoTransaccion;
            _patronService = patronService;
        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = TipoTransaccion == TipoTransaccion.Insertar ? "Agregar Patrón" : "Modificar Patrón";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardar.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardar.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardar.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void btnAgregarTipoDeInstrumento_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnVincularVariableMedicion, "Presione para vincular la variable de medición al patrón");

        }

        private void btnVincularVariableMedicion_Click(object sender, EventArgs e)
        {

        }

        private bool EsValidaLaInformacionIngresadaParaNuevoPatron(out string mensaje)
        {
            if (string.IsNullOrEmpty(NuevoPatron.Nombre))
            {
                mensaje = "Es necesario ingresar un nombre para el patrón.";
                return false;
            }

            if (string.IsNullOrEmpty(NuevoPatron.Link))
            {
                mensaje = "Es necesario ingresar el archivo adjunto que corresponde al patrón.";
                return false;
            }

            mensaje = "Ok";
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PrepararNuevoPatron();
            if (!EsValidaLaInformacionIngresadaParaNuevoPatron(out string mensaje))
            {
                Notificaciones.MensajeAdvertencia(mensaje);
                return;
            }

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));
            if (TipoTransaccion == TipoTransaccion.Insertar)
            {
                if (GuardarPatron())
                {
                    Notificaciones.MensajeConfirmacion("¡El patrón se ha registrado exitosamente!");
                    OnPatronAgregado?.Invoke(NuevoPatron);
                    this.Close();
                }
            }
            else
            {

            }

            SplashScreenManager.CloseForm();
        }

        private bool GuardarPatron()
        {
            try
            {
                var resultado = _patronService.RegistrarPatron(NuevoPatron);
                if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void PrepararNuevoPatron()
        {
            NuevoPatron.Nombre = txtNombreRango.Text;
            NuevoPatron.FechaCaducidad = dateFechaCaducidad.Value;
            NuevoPatron.Link = txtRutaArchivo.Text;

        }

        private void btnAdjunto_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAdjunto, "Presione para iniciar búsqueda de archivo adjunto.");
        }
    }

}