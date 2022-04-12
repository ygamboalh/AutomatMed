using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomatMediciones.DesktopApp.Pantallas.Marcas
{
    public partial class frmMarcas : DevExpress.XtraEditors.XtraForm
    {

        ICollection<MarcaDto> marcas = new List<MarcaDto>();

        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private readonly MarcaService _marcaService;

        public frmMarcas(MarcaService marcaService)
        {
            InitializeComponent();
            _marcaService = marcaService;

            EstablecerNombreYTitulo();
            EstablecerColorBotonPorDefecto();
            CargarMarcas();

            cmdEditar.Click += OnSeleccionaMarcaParaModificar;

        }


        private void OnSeleccionaMarcaParaModificar(object sender, EventArgs e)
        {
            var marca = gvMarcas.GetFocusedRow() as MarcaDto;
            if (marca == null) return;


            var frmNuevaMarca = serviceProvider.GetService<frmNuevaMarca>();
            frmNuevaMarca.TipoTransaccion = TipoTransaccion.Actualizar;
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

        private void CargarMarcas()
        {
            var resultado = _marcaService.ObtenerMarcas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var marcasRespuesta = resultado.Data;
            marcas = marcasRespuesta;

            gcMarcas.DataSource = marcas;

            SetearTotales();
        }

        private void btnAgregarNuevInstrumento_Click(object sender, System.EventArgs e)
        {
            var frmNuevaMarca = serviceProvider.GetService<frmNuevaMarca>();
            frmNuevaMarca.TipoTransaccion = TipoTransaccion.Insertar;
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