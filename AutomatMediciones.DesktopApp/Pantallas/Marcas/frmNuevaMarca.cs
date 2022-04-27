using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Marcas
{
    public partial class frmNuevaMarca : DevExpress.XtraEditors.XtraForm
    {
        private readonly MarcaService _marcaService;

        public delegate void MarcaAgregada(MarcaDto tipoInstrumento);
        public event MarcaAgregada OnMarcaAgregada;

        public delegate void MarcaModificada(MarcaDto tipoInstrumento);
        public event MarcaModificada OnMarcaModificada;

        public TipoTransaccion TipoTransaccion { get; set; }

        public MarcaDto NuevaMarca { get; set; }
        public frmNuevaMarca(TipoTransaccion tipoTransaccion, MarcaService marcaService)
        {
            InitializeComponent();

            TipoTransaccion = tipoTransaccion;
            _marcaService = marcaService;
            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonGuardar();
            NuevaMarca = new MarcaDto();
        }

        public void SetearValoresParaActualizar()
        {
            txtDescripcion.Text = NuevaMarca.Descripcion;
        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = TipoTransaccion == TipoTransaccion.Insertar ? "Agregar Marca" : "Modificar Marca";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarMarca.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarMarca.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarMarca.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private bool GuardarMarca()
        {
            try
            {
                var resultado = _marcaService.RegistrarMarca(NuevaMarca);
                if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private bool ActualizarMarca()
        {
            try
            {
                var resultado = _marcaService.ActualizarMarca(NuevaMarca);
                if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void PrepararNuevaMarca()
        {
            NuevaMarca.Descripcion = txtDescripcion.Text;

        }


        private bool EsValidaLaInformacionIngresadaParaNuevoTipoInstrumento(out string mensaje)
        {
            if (string.IsNullOrEmpty(NuevaMarca.Descripcion))
            {
                mensaje = "Es necesario ingresar una descripción para la marca.";
                return false;
            }
            mensaje = "Ok";
            return true;
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            PrepararNuevaMarca();

            if (!EsValidaLaInformacionIngresadaParaNuevoTipoInstrumento(out string mensaje))
            {
                Notificaciones.MensajeAdvertencia(mensaje);
                return;
            }

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));
            if (TipoTransaccion == TipoTransaccion.Insertar)
            {
                if (GuardarMarca())
                {
                    Notificaciones.MensajeConfirmacion("¡La marca se ha registrado exitosamente!");
                    OnMarcaAgregada?.Invoke(NuevaMarca);
                    this.Close();
                }
            }
            else
            {
                if (ActualizarMarca())
                {

                    Notificaciones.MensajeConfirmacion("¡La marca se ha actualizado exitosamente!");
                    OnMarcaModificada?.Invoke(NuevaMarca);
                    this.Close();
                }
            }

            SplashScreenManager.CloseForm();
        }
    }
}