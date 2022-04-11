using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Requests;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Libs.Dtos;
using MessageBox = System.Windows.Forms.MessageBox;

namespace AutomatMediciones.DesktopApp.Pantallas.Clasificaciones
{
    public partial class frmNuevaClasificacion : DevExpress.XtraEditors.XtraForm
    {
        public delegate void ClasificacionInstrumentoAgregada(ClasificacionInstrumentoDto tipoInstrumento);
        public event ClasificacionInstrumentoAgregada OnClasificacionInstrumentoAgregada;

        public delegate void ClasificacionInstrumentoModificada(ClasificacionInstrumentoDto tipoInstrumento);
        public event ClasificacionInstrumentoModificada OnClasificacionInstrumentoModificada;

        string rutaApi;
        private readonly TipoTransaccion _tipoTransaccion;

        public ICollection<ModeloDto> modelos = new List<ModeloDto>();
        public ICollection<MarcaDto> marcas = new List<MarcaDto>();
        public ICollection<TipoInstrumentoDto> tiposDeInstrumento = new List<TipoInstrumentoDto>();

        public ClasificacionInstrumentoDto NuevaClasificacion { get; set; }
        public frmNuevaClasificacion(TipoTransaccion tipoTransaccion)
        {
            InitializeComponent();
            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();
            _tipoTransaccion = tipoTransaccion;
            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonGuardar();

            NuevaClasificacion = new ClasificacionInstrumentoDto();

        }

        public void InicializarMaestros()
        {
            glMarca.Properties.DataSource = marcas;
            glModelo.Properties.DataSource = modelos;
            glTipoInstrumento.Properties.DataSource = tiposDeInstrumento;

            glMarca.Properties.DisplayMember = "Descripcion";
            glMarca.Properties.ValueMember = "MarcaId";

            glModelo.Properties.DisplayMember = "Descripcion";
            glModelo.Properties.ValueMember = "ModeloId";

            glTipoInstrumento.Properties.DisplayMember = "Descripcion";
            glTipoInstrumento.Properties.ValueMember = "TipoInstrumentoId";
        }

        public void SetearValoresParaActualizar()
        {
            glModelo.EditValue = NuevaClasificacion.ModeloId;
            glMarca.EditValue = NuevaClasificacion.MarcaId;
            glTipoInstrumento.EditValue = NuevaClasificacion.TipoInstrumentoId;
            nmPeriodoCalibracion.Value = NuevaClasificacion.PeriodoDeCalibracion;
        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            this.Text = "";
            ctlEncabezadoPantalla1.lblTitulo.Text = _tipoTransaccion == TipoTransaccion.Insertar ? "Agregar Clasificación  de Instrumento" : "Modificar Clasificación de Instrumento";
            ctlEncabezadoPantalla1.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarClasificacion.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarClasificacion.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarClasificacion.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private async Task<bool> GuardarClasificacionInstrumento()
        {
            bool guardado = false;
            string uri = "/clasificaciones-instrumentos";

            try
            {
                guardado = await HttpHelper.Post<ClasificacionInstrumentoDto>(NuevaClasificacion, rutaApi, uri, "");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Tactica Reparaciones", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
            }

            return guardado;
        }

        private async Task<bool> ActualizarClasificacionInstrumento()
        {
            bool guardado = false;
            string uri = "/clasificaciones-instrumentos";

            try
            {
                guardado = await HttpHelper.Put<ClasificacionInstrumentoDto>(NuevaClasificacion, rutaApi, uri, "");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Tactica Reparaciones", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
            }

            return guardado;
        }

        private void PrepararNuevaClasificacionInstrumento()
        {
            NuevaClasificacion.TipoInstrumentoId = (int)glTipoInstrumento.EditValue;
            NuevaClasificacion.MarcaId = (int)glMarca.EditValue;
            NuevaClasificacion.ModeloId = (int)glModelo.EditValue;
            NuevaClasificacion.PeriodoDeCalibracion = (int)nmPeriodoCalibracion.Value;
        }


        private bool EsValidaLaInformacionIngresadaParaNuevaClasificacion(out string mensaje)
        {


            if (NuevaClasificacion.TipoInstrumentoId == 0)
            {
                mensaje = "Es necesario ingresar un Tipo de Instrumento para la Clasificación del Instrumento.";
                return false;
            }
            if (NuevaClasificacion.MarcaId == 0)
            {
                mensaje = "Es necesario ingresar una Marca para la Clasificación del Instrumento.";
                return false;
            }
            if (NuevaClasificacion.ModeloId == 0)
            {
                mensaje = "Es necesario ingresar un Modelo para la Clasificación del Instrumento.";
                return false;
            }
            mensaje = "Ok";
            return true;
        }

        private async void btnGuardarClasificacionInstrumento_Click(object sender, EventArgs e)
        {
            PrepararNuevaClasificacionInstrumento();

            if (!EsValidaLaInformacionIngresadaParaNuevaClasificacion(out string mensaje))
            {
                MessageBox.Show(mensaje);
                return;
            }

            if (_tipoTransaccion == TipoTransaccion.Insertar)
            {
                if ((await GuardarClasificacionInstrumento()))
                {
                    MessageBox.Show("¡La Clasificación de Instrumento se ha registrado exitosamente!", "Tactica Reparaciones", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
                    OnClasificacionInstrumentoAgregada?.Invoke(NuevaClasificacion);
                    this.Close();
                }
            }
            else
            {
                if ((await ActualizarClasificacionInstrumento()))
                {
                    MessageBox.Show("¡La Clasificación de Instrumento se ha actualizado exitosamente!", "Tactica Reparaciones", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
                    OnClasificacionInstrumentoModificada?.Invoke(NuevaClasificacion);
                    this.Close();
                }
            }
        }
    }
}