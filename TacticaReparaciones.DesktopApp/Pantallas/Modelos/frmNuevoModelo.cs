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
using System.Windows.Forms;
using TacticaReparaciones.DesktopApp.Enums;
using TacticaReparaciones.DesktopApp.Helpers;
using TacticaReparaciones.Libs.Dtos;
using MessageBox = System.Windows.Forms.MessageBox;

namespace TacticaReparaciones.DesktopApp.Pantallas.Modelos
{
    public partial class frmNuevoModelo : DevExpress.XtraEditors.XtraForm
    {
        public delegate void ModeloAgregada(ModeloDto modelo);
        public event ModeloAgregada OnModeloAgregada;

        public delegate void ModeloModificada(ModeloDto modelo);
        public event ModeloModificada OnModeloModificada;

        string rutaApi;
        private readonly TipoTransaccion _tipoTransaccion;

        public ModeloDto NuevaModelo { get; set; }
        public frmNuevoModelo(TipoTransaccion tipoTransaccion)
        {
            InitializeComponent();
            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();
            _tipoTransaccion = tipoTransaccion;
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
            ctlEncabezadoPantalla1.lblTitulo.Text = _tipoTransaccion == TipoTransaccion.Insertar ? "Agregar Modelo" : "Modificar Modelo";
            ctlEncabezadoPantalla1.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarModelo.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarModelo.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarModelo.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private async Task<bool> GuardarModelo()
        {
            bool guardado = false;
            string uri = "/Modelos";

            try
            {
                guardado = await HttpHelper.Post<ModeloDto>(NuevaModelo, rutaApi, uri, "");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Tactica Reparaciones", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
            }

            return guardado;
        }

        private async Task<bool> ActualizarModelo()
        {
            bool guardado = false;
            string uri = "/Modelos";

            try
            {
                guardado = await HttpHelper.Patch<ModeloDto>(NuevaModelo, rutaApi, uri, "");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Tactica Reparaciones", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
            }

            return guardado;
        }

        private void PrepararNuevaModelo()
        {
            NuevaModelo.Descripcion = txtDescripcion.Text;

        }


        private bool EsValidaLaInformacionIngresadaParaNuevoModelo(out string mensaje)
        {


            if (string.IsNullOrEmpty(NuevaModelo.Descripcion))
            {
                mensaje = "Es necesario ingresar una descripción para la Modelo.";
                return false;
            }
            mensaje = "Ok";
            return true;
        }

        private async void btnGuardarModelo_Click(object sender, EventArgs e)
        {
            PrepararNuevaModelo();

            if (!EsValidaLaInformacionIngresadaParaNuevoModelo(out string mensaje))
            {
                MessageBox.Show(mensaje);
                return;
            }

            if (_tipoTransaccion == TipoTransaccion.Insertar)
            {
                if ((await GuardarModelo()))
                {
                    MessageBox.Show("¡La Modelo se ha registrado exitosamente!", "Tactica Reparaciones", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
                    OnModeloAgregada?.Invoke(NuevaModelo);
                    this.Close();
                }
            }
            else
            {
                if ((await ActualizarModelo()))
                {
                    MessageBox.Show("¡La Modelo se ha actualizado exitosamente!", "Tactica Reparaciones", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Information);
                    OnModeloModificada?.Invoke(NuevaModelo);
                    this.Close();
                }
            }
        }
    }
}