using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Libs.Dtos;

namespace AutomatMediciones.DesktopApp.Pantallas.Marcas
{
    public partial class frmMarcas : DevExpress.XtraEditors.XtraForm
    {
        string rutaApi;
        ICollection<MarcaDto> marcas = new List<MarcaDto>();

        public frmMarcas()
        {
            InitializeComponent();
            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();
            EstablecerNombreYTitulo();
            EstablecerColorBotonPorDefecto();
            CargarMarcas();

            cmdEditar.Click += OnSeleccionaMarcaParaModificar;
        }

        private void OnSeleccionaMarcaParaModificar(object sender, EventArgs e)
        {
            var marca = gvMarcas.GetFocusedRow() as MarcaDto;
            frmNuevaMarca frmNuevaMarca = new frmNuevaMarca(TipoTransaccion.Actualizar);
            frmNuevaMarca.NuevaMarca = marca;
            frmNuevaMarca.SetearValoresParaActualizar();
            frmNuevaMarca.OnMarcaModificada += OnMarcaModificada;
            frmNuevaMarca.Show();
        }

        private void OnMarcaModificada(MarcaDto marca)
        {
            marcas = marcas.Where(x => x.MarcaId != marca.MarcaId).ToList();
            marcas.Add(marca);

            gcMarcas.DataSource = marcas;
            gcMarcas.RefreshDataSource();

            SetearTotales();
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {marcas.Count}";
            lblTotal.Visible = true;
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla3.lblTitulo.Text = "Marcas";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonPorDefecto()
        {
            btnAgregarNuevInstrumento.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnAgregarNuevInstrumento.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarNuevInstrumento.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private async void CargarMarcas()
        {
            string uri = "/marcas";
            var marcasRespuesta = await HttpHelper.Get<MarcaDto>(rutaApi, uri, "");
            marcas = marcasRespuesta;

            gcMarcas.DataSource = marcas;

            SetearTotales();
        }

        private void btnAgregarNuevInstrumento_Click(object sender, System.EventArgs e)
        {
            frmNuevaMarca frmNuevaMarca = new frmNuevaMarca(TipoTransaccion.Insertar);
            frmNuevaMarca.OnMarcaAgregada += OnMarcaAgregada;
            frmNuevaMarca.Show();
        }

        private void OnMarcaAgregada(MarcaDto marca)
        {
            marcas.Add(marca);
            gcMarcas.DataSource = marca;
            gcMarcas.RefreshDataSource();

            SetearTotales();
        }
    }
}