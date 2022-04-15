using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using MessageBox = System.Windows.Forms.MessageBox;

namespace AutomatMediciones.DesktopApp.Pantallas.Modelos
{
    public partial class frmNuevoModelo : DevExpress.XtraEditors.XtraForm
    {
        private readonly ModeloService _modeloService;

        public delegate void ModeloAgregada(ModeloDto modelo);
        public event ModeloAgregada OnModeloAgregada;

        public delegate void ModeloModificada(ModeloDto modelo);
        public event ModeloModificada OnModeloModificada;

        public TipoTransaccion TipoTransaccion { get; set; }
        public ModeloDto NuevaModelo { get; set; }

        public frmNuevoModelo(TipoTransaccion tipoTransaccion, ModeloService modeloService)
        {
            InitializeComponent();
            TipoTransaccion = tipoTransaccion;
            _modeloService = modeloService;

            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonGuardar();

            NuevaModelo = new ModeloDto();
        }

        public void SetearValoresParaActualizar()
        {
            txtDescripcion.Text = NuevaModelo.Descripcion;
        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            this.Text = "";
            ctlEncabezadoPantalla1.lblTitulo.Text = TipoTransaccion == TipoTransaccion.Insertar ? "Agregar Modelo" : "Modificar Modelo";
            ctlEncabezadoPantalla1.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarModelo.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarModelo.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarModelo.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private bool GuardarModelo()
        {

            try
            {
                var resultado = _modeloService.RegistrarModelo(NuevaModelo);
                if (resultado.Type != TypeResponse.Ok) return false;

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private bool ActualizarModelo()
        {

            try
            {
                var resultado = _modeloService.ActualizarModelo(NuevaModelo);
                if (resultado.Type != TypeResponse.Ok) return false;

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void PrepararNuevaModelo()
        {
            NuevaModelo.Descripcion = txtDescripcion.Text;

        }


        private bool EsValidaLaInformacionIngresadaParaNuevoModelo(out string mensaje)
        {
            if (string.IsNullOrEmpty(NuevaModelo.Descripcion))
            {
                mensaje = "Es necesario ingresar una descripción para el Modelo.";
                return false;
            }
            mensaje = "Ok";
            return true;
        }

        private void btnGuardarModelo_Click(object sender, EventArgs e)
        {
            PrepararNuevaModelo();

            if (!EsValidaLaInformacionIngresadaParaNuevoModelo(out string mensaje))
            {
                MessageBox.Show(mensaje);
                return;
            }

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));
            if (TipoTransaccion == TipoTransaccion.Insertar)
            {
                if (GuardarModelo())
                {
                    Notificaciones.MensajeConfirmacion("¡El Modelo se ha registrado exitosamente!");
                    OnModeloAgregada?.Invoke(NuevaModelo);
                    this.Close();
                }
            }
            else
            {
                if (ActualizarModelo())
                {
                    Notificaciones.MensajeConfirmacion("¡El Modelo se ha actualizado exitosamente!");
                    OnModeloModificada?.Invoke(NuevaModelo);
                    this.Close();
                }
            }
            SplashScreenManager.CloseForm();
        }
    }
}