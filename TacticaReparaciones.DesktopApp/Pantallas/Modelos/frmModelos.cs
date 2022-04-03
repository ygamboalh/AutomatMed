using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TacticaReparaciones.DesktopApp.Enums;
using TacticaReparaciones.DesktopApp.Helpers;
using TacticaReparaciones.Libs.Dtos;

namespace TacticaReparaciones.DesktopApp.Pantallas.Modelos
{
    public partial class frmModelos : DevExpress.XtraEditors.XtraForm
    {
        string rutaApi;
        ICollection<ModeloDto> Modelos = new List<ModeloDto>();

        public frmModelos()
        {
            InitializeComponent();
            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();
            EstablecerNombreYTitulo();
            EstablecerColorBotonPorDefecto();
            CargarModelos();

            cmdEditar.Click += OnSeleccionaModeloParaModificar;
        }

        private void OnSeleccionaModeloParaModificar(object sender, EventArgs e)
        {
            var Modelo = gvModelos.GetFocusedRow() as ModeloDto;
            frmNuevoModelo frmNuevoModelo = new frmNuevoModelo(TipoTransaccion.Actualizar);
            frmNuevoModelo.NuevaModelo = Modelo;
            frmNuevoModelo.SetearValoresParaActualizar();
            frmNuevoModelo.OnModeloModificada += OnModeloModificada;
            frmNuevoModelo.Show();
        }

        private void OnModeloModificada(ModeloDto Modelo)
        {
            Modelos = Modelos.Where(x => x.ModeloId != Modelo.ModeloId).ToList();
            Modelos.Add(Modelo);

            gcModelos.DataSource = Modelos;
            gcModelos.RefreshDataSource();

            SetearTotales();
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {Modelos.Count}";
            lblTotal.Visible = true;
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla3.lblTitulo.Text = "Modelos";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonPorDefecto()
        {
            btnAgregarNuevoModelo.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnAgregarNuevoModelo.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarNuevoModelo.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private async void CargarModelos()
        {
            string uri = "/Modelos";
            var ModelosRespuesta = await HttpHelper.Get<ModeloDto>(rutaApi, uri, "");
            Modelos = ModelosRespuesta;

            gcModelos.DataSource = Modelos;

            SetearTotales();
        }

        private void btnAgregarNuevoModelo_Click(object sender, System.EventArgs e)
        {
            frmNuevoModelo frmNuevoModelo = new frmNuevoModelo(TipoTransaccion.Insertar);
            frmNuevoModelo.OnModeloAgregada += OnModeloAgregada;
            frmNuevoModelo.Show();
        }

        private void OnModeloAgregada(ModeloDto Modelo)
        {
            Modelos.Add(Modelo);
            gcModelos.DataSource = Modelo;
            gcModelos.RefreshDataSource();

            SetearTotales();
        }
    }
}