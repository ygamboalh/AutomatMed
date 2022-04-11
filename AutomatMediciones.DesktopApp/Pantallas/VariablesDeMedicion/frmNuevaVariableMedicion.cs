using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Libs.Dtos;
using MessageBox = System.Windows.Forms.MessageBox;

namespace AutomatMediciones.DesktopApp.Pantallas.VariablesDeMedicion
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
            CargarTiposDeInstrumentos();
            btnEliminar.Click += onClickBotonEliminar;

        }

        private void onClickBotonEliminar(object sender, EventArgs e)
        {
            var tipoInstrumentoVariableSeleccionado = gvTiposDeInstrumento.GetFocusedRow() as TipoInstrumentoVariableDto;
            NuevaVariableMedicion.TiposDeInstrumentoVariables = NuevaVariableMedicion.TiposDeInstrumentoVariables
                                                                                     .Where(x => x.TipoInstrumentoId == tipoInstrumentoVariableSeleccionado.TipoInstrumentoId).ToList();

            AsignarTotales();
        }

        public void SetearValoresParaActualizar()
        {
            txtDescripcion.Text = NuevaVariableMedicion.Descripcion;
            nmPrimerValorRango.Value = NuevaVariableMedicion.PrimerValorRango;
            nmSegundoValorRango.Value = NuevaVariableMedicion.SegundoValorRango;
            nmTolerancia.Value = NuevaVariableMedicion.Tolerancia;

            if (NuevaVariableMedicion.TiposDeInstrumentoVariables.Any())
            {
                gcTiposDeInstrumento.DataSource = NuevaVariableMedicion.TiposDeInstrumentoVariables;
            }

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
                var json = JsonSerializer.Serialize(NuevaVariableMedicion);
                guardado = await HttpHelper.Post<VariableMedicionDto>(NuevaVariableMedicion, rutaApi, uri, "");
            }
            catch (Exception exc)
            {
                string message = exc.InnerException == null ? exc.Message : exc.InnerException.Message;
                MessageBox.Show(message, "Tactica Reparaciones", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
            }

            return guardado;
        }

        private async void CargarTiposDeInstrumentos()
        {
            string uri = "/tipos-de-instrumento";
            var tiposDeInstrumentos = await HttpHelper.Get<TipoInstrumentoDto>(rutaApi, uri, "");

            glTipoInstrumento.Properties.DataSource = tiposDeInstrumentos;
            glTipoInstrumento.Properties.DisplayMember = "Descripcion";
            glTipoInstrumento.Properties.ValueMember = "TipoInstrumentoId";
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

        private void btnAgregarTipoDeInstrumento_Click(object sender, EventArgs e)
        {
            if (glTipoInstrumento.EditValue == null)
            {
                MessageBox.Show("Es necesario que seleccione un tipo de instrumento para continuar.");
                return;
            }

            if (NuevaVariableMedicion.TiposDeInstrumentoVariables == null)
            {
                NuevaVariableMedicion.TiposDeInstrumentoVariables = new List<TipoInstrumentoVariableDto>();
            }

            var tipoInstrumentoSeleccionado = glTipoInstrumentoView.GetFocusedRow() as TipoInstrumentoDto;
            var existeEnLista = NuevaVariableMedicion.TiposDeInstrumentoVariables.Any(x => x.TipoInstrumentoId == tipoInstrumentoSeleccionado.TipoInstrumentoId);

            if (existeEnLista)
            {
                MessageBox.Show("Este tipo de instrumento ya está agregado en la lista.");
                return;
            }

            NuevaVariableMedicion.TiposDeInstrumentoVariables.Add(new TipoInstrumentoVariableDto
            {
                TipoInstrumentoId = tipoInstrumentoSeleccionado.TipoInstrumentoId,
                TipoInstrumento = tipoInstrumentoSeleccionado
            });

            AsignarTotales();
        }

        private void AsignarTotales()
        {
            gcTiposDeInstrumento.DataSource = NuevaVariableMedicion.TiposDeInstrumentoVariables;
            gcTiposDeInstrumento.RefreshDataSource();

            lblTotalInstrumentos.Visible = true;
            lblTotalInstrumentos.Text = $"Total Instrumentos: {NuevaVariableMedicion.TiposDeInstrumentoVariables.Count}";
        }
    }
}