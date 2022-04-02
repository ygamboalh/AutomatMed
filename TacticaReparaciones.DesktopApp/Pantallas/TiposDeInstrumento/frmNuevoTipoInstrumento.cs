using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TacticaReparaciones.DesktopApp.Enums;
using TacticaReparaciones.DesktopApp.Helpers;
using TacticaReparaciones.Libs.Dtos;

namespace TacticaReparaciones.DesktopApp.Pantallas.TiposDeInstrumento
{
    public partial class frmNuevoTipoInstrumento : DevExpress.XtraEditors.XtraForm
    {
        public delegate void TipoInstrumentoAgregado(TipoInstrumentoDto tipoInstrumento);
        public event TipoInstrumentoAgregado OnTipoInstrumentoAgregado;

        public delegate void TipoInstrumentoModificado(TipoInstrumentoDto tipoInstrumento);
        public event TipoInstrumentoAgregado OnTipoInstrumentoModificado;

        string rutaApi;
        private readonly TipoTransaccion _tipoTransaccion;

        public TipoInstrumentoDto NuevoTipoInstrumento { get; set; }
        public frmNuevoTipoInstrumento(TipoTransaccion tipoTransaccion)
        {
            InitializeComponent();
            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();
            _tipoTransaccion = tipoTransaccion;
            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonGuardar();
         
            
            NuevoTipoInstrumento = new TipoInstrumentoDto();
            
        }

        public void SetearValoresParaActualizar()
        {
            txtDescripcion.Text = NuevoTipoInstrumento.Descripcion;
            txtMetodologia.Text = NuevoTipoInstrumento.Metodologia;
            txtResumen.Text = NuevoTipoInstrumento.Resumen;
        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            this.Text = "";
            ctlEncabezadoPantalla1.lblTitulo.Text = _tipoTransaccion == TipoTransaccion.Insertar ?  "Agregar Tipo de Instrumento" : "Modificar Tipo de Instrumento";
            ctlEncabezadoPantalla1.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarInstrumento.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarInstrumento.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarInstrumento.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private async void btnGuardarInstrumento_Click(object sender, EventArgs e)
        {
            
            PrepararNuevoTipoInstrumento();
            
            if (!EsValidaLaInformacionIngresadaParaNuevoTipoInstrumento(out string mensaje))
            {
                MessageBox.Show(mensaje);
                return;
            }

            if (_tipoTransaccion == TipoTransaccion.Insertar)
            {
                if ((await GuardarTipoInstrumento()))
                {
                    MessageBox.Show("¡El tipo de instrumento se ha registrado exitosamente!", "Tactica Reparaciones", MessageBoxButton.OK, MessageBoxImage.Information);
                    OnTipoInstrumentoAgregado?.Invoke(NuevoTipoInstrumento);
                    this.Close();
                }
            }
            else
            {
                if ((await ActualizarTipoInstrumento()))
                {
                    MessageBox.Show("¡El tipo de instrumento se ha actualizado exitosamente!", "Tactica Reparaciones", MessageBoxButton.OK, MessageBoxImage.Information);
                    OnTipoInstrumentoModificado?.Invoke(NuevoTipoInstrumento);
                    this.Close();
                }
            }
           
        }


        private async Task<bool> GuardarTipoInstrumento()
        {
            bool guardado = false;
            string uri = "/tipos-de-instrumento";

            try
            {
                guardado = await HttpHelper.Post<TipoInstrumentoDto>(NuevoTipoInstrumento, rutaApi, uri, "");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Tactica Reparaciones", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return guardado;
        }

        private async Task<bool> ActualizarTipoInstrumento()
        {
            bool guardado = false;
            string uri = "/tipos-de-instrumento";

            try
            {
                guardado = await HttpHelper.Patch<TipoInstrumentoDto>(NuevoTipoInstrumento, rutaApi, uri, "");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Tactica Reparaciones", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return guardado;
        }

        private void PrepararNuevoTipoInstrumento()
        {
            NuevoTipoInstrumento.Descripcion = txtDescripcion.Text;
            NuevoTipoInstrumento.Metodologia = txtMetodologia.Text;
            NuevoTipoInstrumento.Resumen = txtResumen.Text;
        }


        private bool EsValidaLaInformacionIngresadaParaNuevoTipoInstrumento(out string mensaje)
        {
           

            if (string.IsNullOrEmpty(NuevoTipoInstrumento.Descripcion))
            {
                mensaje = "Es necesario ingresar una descripción para el tipo de instrumento.";
                return false;
            }

            if (string.IsNullOrEmpty(NuevoTipoInstrumento.Resumen))
            {
                mensaje = "Es necesario ingresar un resumen para el tipo de instrumento.";
                return false;
            }

            if (string.IsNullOrEmpty(NuevoTipoInstrumento.Metodologia))
            {
                mensaje = "Es necesario ingresar una metodología para el tipo de instrumento.";
                return false;
            }

            mensaje = "Ok";
            return true;
        }
    }
}