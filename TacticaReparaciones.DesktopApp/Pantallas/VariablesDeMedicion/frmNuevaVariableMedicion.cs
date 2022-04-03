using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Requests;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using TacticaReparaciones.DesktopApp.Helpers;
using TacticaReparaciones.Libs.Dtos;
using MessageBox = System.Windows.Forms.MessageBox;

namespace TacticaReparaciones.DesktopApp.Pantallas.VariablesDeMedicion
{
    public partial class frmNuevaVariableMedicion : DevExpress.XtraEditors.XtraForm
    {
        public delegate void VariableMedicionAgregada(VariableMedicionDto tipoInstrumento);
        public event VariableMedicionAgregada OnVariableMedicionAgregada;

        public delegate void VariableMedicionModificada(VariableMedicionDto tipoInstrumento);
        public event VariableMedicionModificada OnVariableMedicionModificada;

        string rutaApi;
        private readonly TipoTransaccion _tipoTransaccion;

        public VariableMedicionDto NuevaVariableMedicion { get; set; }
        public frmNuevaVariableMedicion(TipoTransaccion tipoTransaccion)
        {
            InitializeComponent();
            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();
            _tipoTransaccion = tipoTransaccion;
            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonGuardar();

            NuevaVariableMedicion = new VariableMedicionDto();

        }

        public void SetearValoresParaActualizar()
        {
            txtDescripcion.Text = NuevaVariableMedicion.Descripcion;
            nmPrimerValorRango.Value = NuevaVariableMedicion.PrimerValorRango;
            nmSegundoValorRango.Value = NuevaVariableMedicion.SegundoValorRango;
            nmTolerancia.Value = NuevaVariableMedicion.Tolerancia;
        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            this.Text = "";
            ctlEncabezadoPantalla1.lblTitulo.Text = _tipoTransaccion == TipoTransaccion.Insertar ? "Agregar Variable de Medición" : "Modificar Variable de Medición";
            ctlEncabezadoPantalla1.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarVariableMedicion.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarVariableMedicion.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarVariableMedicion.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private async Task<bool> GuardarVariableMedicion()
        {
            bool guardado = false;
            string uri = "/variables-de-medicion";

            try
            {
                guardado = await HttpHelper.Post<VariableMedicionDto>(NuevaVariableMedicion, rutaApi, uri, "");
            }
            catch (Exception exc)
            {
                string message = exc.InnerException == null ? exc.Message : exc.InnerException.Message;
                MessageBox.Show(message, "Tactica Reparaciones", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
            }

            return guardado;
        }

        private async Task<bool> ActualizarVariableMedicion()
        {
            bool guardado = false;
            string uri = "/variables-de-medicion";

            try
            {
                guardado = await HttpHelper.Put<VariableMedicionDto>(NuevaVariableMedicion, rutaApi, uri, "");
            }
            catch (Exception exc)
            {
                string message = exc.InnerException == null ? exc.Message : exc.InnerException.Message;
                MessageBox.Show(message, "Tactica Reparaciones", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
            }

            return guardado;
        }

        private void PrepararNuevaVariableMedicion()
        {
            NuevaVariableMedicion.Descripcion = txtDescripcion.Text;
            NuevaVariableMedicion.PrimerValorRango = nmPrimerValorRango.Value;
            NuevaVariableMedicion.SegundoValorRango = nmSegundoValorRango.Value;
            NuevaVariableMedicion.Tolerancia = nmTolerancia.Value;
        }


        private bool EsValidaLaInformacionIngresadaParaNuevoTipoInstrumento(out string mensaje)
        {


            if (string.IsNullOrEmpty(NuevaVariableMedicion.Descripcion))
            {
                mensaje = "Es necesario ingresar una descripción para la Variable de Medición.";
                return false;
            }
            mensaje = "Ok";
            return true;
        }

        private async void btnGuardarVariableMedicion_Click(object sender, EventArgs e)
        {
            PrepararNuevaVariableMedicion();

            if (!EsValidaLaInformacionIngresadaParaNuevoTipoInstrumento(out string mensaje))
            {
                MessageBox.Show(mensaje);
                return;
            }

            if (_tipoTransaccion == TipoTransaccion.Insertar)
            {
                if ((await GuardarVariableMedicion()))
                {
                    MessageBox.Show("¡La Variable de Medición se ha registrado exitosamente!", "Tactica Reparaciones", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
                    OnVariableMedicionAgregada?.Invoke(NuevaVariableMedicion);
                    this.Close();
                }
            }
            else
            {
                if ((await ActualizarVariableMedicion()))
                {
                    MessageBox.Show("¡La Variable de Medición se ha actualizado exitosamente!", "Tactica Reparaciones", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
                    OnVariableMedicionModificada?.Invoke(NuevaVariableMedicion);
                    this.Close();
                }
            }
        }
    }
}