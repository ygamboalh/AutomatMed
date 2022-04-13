using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AutomatMediciones.DesktopApp.Pantallas.Modelos
{
    public partial class frmModelos : DevExpress.XtraEditors.XtraForm
    {
        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private readonly ModeloService _modeloService;

        ICollection<ModeloDto> Modelos = new List<ModeloDto>();

        public frmModelos(ModeloService modeloService)
        {
            InitializeComponent();

            _modeloService = modeloService;
            EstablecerNombreYTitulo();
            EstablecerColorBotonPorDefecto();
            CargarModelos();

            cmdEditar.Click += OnSeleccionaModeloParaModificar;

        }

        private void OnSeleccionaModeloParaModificar(object sender, EventArgs e)
        {
            var modelo = gvModelos.GetFocusedRow() as ModeloDto;
            if (modelo == null) return;

            var frmNuevoModelo = new frmNuevoModelo(TipoTransaccion.Actualizar, serviceProvider.GetService<ModeloService>());        
            frmNuevoModelo.NuevaModelo = modelo;
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
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = System.Windows.Forms.DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Modelos";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonPorDefecto()
        {
            btnAgregarNuevoModelo.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnAgregarNuevoModelo.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarNuevoModelo.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void CargarModelos()
        {
            var resultado = _modeloService.ObtenerModelos();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var modelosRespuesta = resultado.Data;
            Modelos = modelosRespuesta;

            gcModelos.DataSource = Modelos;

            SetearTotales();
        }

        private void btnAgregarNuevoModelo_Click(object sender, System.EventArgs e)
        {
            var frmNuevoModelo = new frmNuevoModelo(TipoTransaccion.Insertar, serviceProvider.GetService<ModeloService>());
      
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