using Nagaira.Herramientas.Standard.Helpers.Requests;
using System;
using System.Threading.Tasks;
using System.Windows;
using TacticaReparaciones.DesktopApp.Helpers;
using TacticaReparaciones.DesktopApp.Pantallas.Clasificaciones.Dtos;
using TacticaReparaciones.Libs.Dtos;

namespace TacticaReparaciones.DesktopApp.Pantallas
{
    public partial class frmNuevoInstrumento : DevExpress.XtraEditors.XtraForm
    {
        public delegate void InstrumentoAgregado(InstrumentoDto instrumento);
        public event InstrumentoAgregado OnInstrumentoAgregado;

        EmpresaDto empresaSeleccionada;
        public InstrumentoDto NuevoInstrumento { get; set; }
        string rutaApi;

        public frmNuevoInstrumento()
        {
            InitializeComponent();

            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();
            CargarClasificacionesDeInstrumentos();
            AsignarConfiguracionComboBoxes();
            EstablecerColorBotonGuardar();
            EstablecerNombreYTituloPopupAgregarInstrumentos();

            NuevoInstrumento = new InstrumentoDto();
        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            this.Text = "";
            ctlEncabezadoAgregarInstrumento.lblTitulo.Text = "Agregar Instrumento";
            ctlEncabezadoAgregarInstrumento.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarInstrumento.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarInstrumento.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarInstrumento.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void OnEmpresaSeleccionada(EmpresaDto empresa)
        {
            empresaSeleccionada = empresa;
            txtEmpresaInstrumento.Text = empresa.NombreEmpresa;
        }

        private async void btnGuardarInstrumento_Click(object sender, EventArgs e)
        {
            PrepararNuevoInstrumentoParaGuardar();

            if (!EsValidaLaInformacionIngresadaParaNuevoInstrumento(out string mensaje))
            {
                MessageBox.Show(mensaje);
                return;
            }

            if ((await GuardarInstrumento()))
            {
                MessageBox.Show("¡El instrumento se ha registrado exitosamente!", "Tactica Reparaciones", MessageBoxButton.OK, MessageBoxImage.Information);
                OnInstrumentoAgregado?.Invoke(NuevoInstrumento);
                this.Close();
            }
        }

        private void btnAbrirPopupEmpresaPorInstrumento_Click(object sender, EventArgs e)
        {
            frmEmpresas frmEmpresas = new frmEmpresas();
            frmEmpresas.OnSeleccionaEmpresa += OnEmpresaSeleccionada;
            frmEmpresas.Show();
        }

        private async void CargarClasificacionesDeInstrumentos()
        {
            string uri = "/clasificaciones-instrumentos";
            var clasificaciones = await HttpHelper.Get<ClasificacionDto>(rutaApi, uri, "");

            if (clasificaciones != null)
            {
                clasificaciones.ForEach(x => x.DescripcionCompuesta = $"{x.TipoInstrumento.Descripcion} / {x.Marca.Descripcion} / {x.Modelo.Descripcion}");
                glClasificacion.Properties.DataSource = clasificaciones;
            }
        }

        private async Task<bool> GuardarInstrumento()
        {
            bool guardado = false;
            string uri = "/instrumentos";

            try
            {
                guardado = await HttpHelper.Post<InstrumentoDto>(NuevoInstrumento, rutaApi, uri, "");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Tactica Reparaciones", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return guardado;
        }

        private void AsignarConfiguracionComboBoxes()
        {
            glClasificacion.Properties.ValueMember = "ClasificacionId";
            glClasificacion.Properties.DisplayMember = "DescripcionCompuesta";
        }

        private bool EsValidaLaInformacionIngresadaParaNuevoInstrumento(out string mensaje)
        {
            if (string.IsNullOrEmpty(NuevoInstrumento.NombreEmpresa))
            {
                mensaje = "Es necesario ingresar un nombre de empresa para guardar el ingreso.";
                return false;
            }

            if (string.IsNullOrEmpty(NuevoInstrumento.Descripcion))
            {
                mensaje = "Es necesario ingresar una descripción para el instrumento.";
                return false;
            }

            if (NuevoInstrumento.ClasificacionId == 0)
            {
                mensaje = "Es necesario ingresar un tipo de instrumento para el nuevo instrumento.";
                return false;
            }


            mensaje = "Ok";
            return true;
        }

        private void PrepararNuevoInstrumentoParaGuardar()
        {
            var clasificacion = glClasificacion.GetSelectedDataRow() as ClasificacionDto;

            NuevoInstrumento.Descripcion = txtDescripcionInstrumento.Text;
            NuevoInstrumento.EmpresaId = empresaSeleccionada.EmpresaId;
            NuevoInstrumento.NombreEmpresa = empresaSeleccionada.NombreEmpresa;
            NuevoInstrumento.ClasificacionId = clasificacion.ClasificacionId;
            NuevoInstrumento.NumeroSerie = txtNumeroSerie.Text;
            NuevoInstrumento.FechaCompraFabricante = dateFechaCompraFabricante.Value;
            NuevoInstrumento.FechaCompraCliente = dateFechaCompraCliente.Value;
            NuevoInstrumento.FechaUltimaCalibracion = dateUltimaCalibracion.Value;
            NuevoInstrumento.FechaProximaCalibracion = dateProximaCalibracion.Value;
            NuevoInstrumento.Garantia = txtGarantia.Text;
        }

        private void glClasificacion_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}