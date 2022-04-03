using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using TacticaReparaciones.DesktopApp.Enums;
using TacticaReparaciones.DesktopApp.Helpers;
using TacticaReparaciones.Libs.Dtos;
using MessageBox = System.Windows.Forms.MessageBox;

namespace TacticaReparaciones.DesktopApp.Pantallas.Marcas
{
    public partial class frmNuevaMarca : DevExpress.XtraEditors.XtraForm
    {
        public delegate void MarcaAgregada(MarcaDto tipoInstrumento);
        public event MarcaAgregada OnMarcaAgregada;

        public delegate void MarcaModificada(MarcaDto tipoInstrumento);
        public event MarcaModificada OnMarcaModificada;

        string rutaApi;
        private readonly TipoTransaccion _tipoTransaccion;

        public MarcaDto NuevaMarca { get; set; }
        public frmNuevaMarca(TipoTransaccion tipoTransaccion)
        {
            InitializeComponent();
            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();
            _tipoTransaccion = tipoTransaccion;
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
            this.Text = "";
            ctlEncabezadoPantalla1.lblTitulo.Text = _tipoTransaccion == TipoTransaccion.Insertar ? "Agregar Marca" : "Modificar Marca";
            ctlEncabezadoPantalla1.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarMarca.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarMarca.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarMarca.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private async Task<bool> GuardarMarca()
        {
            bool guardado = false;
            string uri = "/marcas";

            try
            {
                guardado = await HttpHelper.Post<MarcaDto>(NuevaMarca, rutaApi, uri, "");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Tactica Reparaciones", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
            }

            return guardado;
        }

        private async Task<bool> ActualizarMarca()
        {
            bool guardado = false;
            string uri = "/marcas";

            try
            {
                guardado = await HttpHelper.Patch<MarcaDto>(NuevaMarca, rutaApi, uri, "");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Tactica Reparaciones", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
            }

            return guardado;
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

        private async void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            PrepararNuevaMarca();

            if (!EsValidaLaInformacionIngresadaParaNuevoTipoInstrumento(out string mensaje))
            {
                MessageBox.Show(mensaje);
                return;
            }

            if (_tipoTransaccion == TipoTransaccion.Insertar)
            {
                if ((await GuardarMarca()))
                {
                    MessageBox.Show("¡La marca se ha registrado exitosamente!", "Tactica Reparaciones", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
                    OnMarcaAgregada?.Invoke(NuevaMarca);
                    this.Close();
                }
            }
            else
            {
                if ((await ActualizarMarca()))
                {
                    MessageBox.Show("¡La marca se ha actualizado exitosamente!", "Tactica Reparaciones", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
                    OnMarcaModificada?.Invoke(NuevaMarca);
                    this.Close();
                }
            }
        }
    }
}