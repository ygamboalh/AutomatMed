using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.VariablesDeMedicion
{
    public partial class frmVariablesDeMedicion : DevExpress.XtraEditors.XtraForm
    {
        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private readonly VariableMedicionService _variableMedicionService;

        ICollection<VariableMedicionDto> variablesDeMedicion = new List<VariableMedicionDto>();

        public frmVariablesDeMedicion(VariableMedicionService variableMedicionService)
        {
            InitializeComponent();

            _variableMedicionService = variableMedicionService;

            EstablecerNombreYTitulo();
            EstablecerColorBotonPorDefecto();
            CargarVariablesDeMedicion();

            cmdEditar.Click += OnSeleccionaVariableMedicionParaModificar;

        }

     

        private void OnSeleccionaVariableMedicionParaModificar(object sender, EventArgs e)
        {
            var VariableMedicion = gvVariablesDeMedicion.GetFocusedRow() as VariableMedicionDto;
            if (variablesDeMedicion == null) return;

            var frmNuevaVariableMedicion = new frmNuevaVariableMedicion(TipoTransaccion.Actualizar, serviceProvider.GetService<VariableMedicionService>(), serviceProvider.GetService<TipoDeInstrumentoService>());

            frmNuevaVariableMedicion.NuevaVariableMedicion = VariableMedicion;
            frmNuevaVariableMedicion.SetearValoresParaActualizar();
            frmNuevaVariableMedicion.OnVariableMedicionModificada += OnVariableMedicionModificada;
            frmNuevaVariableMedicion.ShowDialog();
        }

        private void OnVariableMedicionModificada(VariableMedicionDto VariableMedicion)
        {
            variablesDeMedicion = variablesDeMedicion.Where(x => x.VariableMedicionId != VariableMedicion.VariableMedicionId).ToList();
            variablesDeMedicion.Add(VariableMedicion);

            gcVariablesDeMedicion.DataSource = variablesDeMedicion;
            gcVariablesDeMedicion.RefreshDataSource();

            SetearTotales();
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {variablesDeMedicion.Count}";
            lblTotal.Visible = true;
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Variables de Medición";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonPorDefecto()
        {
            btnAgregarNuevInstrumento.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnAgregarNuevInstrumento.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarNuevInstrumento.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void CargarVariablesDeMedicion()
        {
            var resultado = _variableMedicionService.ObtenerVariablesDeMedicionActivas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            variablesDeMedicion = resultado.Data;

            gcVariablesDeMedicion.DataSource = variablesDeMedicion;

            SetearTotales();
        }

        private void btnAgregarNuevInstrumento_Click(object sender, System.EventArgs e)
        {
            var frmNuevaVariableMedicion = new frmNuevaVariableMedicion(TipoTransaccion.Insertar, serviceProvider.GetService<VariableMedicionService>(), serviceProvider.GetService<TipoDeInstrumentoService>());
            frmNuevaVariableMedicion.OnVariableMedicionAgregada += OnVariableMedicionAgregada;
            frmNuevaVariableMedicion.ShowDialog();
        }

        private void OnVariableMedicionAgregada(VariableMedicionDto VariableMedicion)
        {
            variablesDeMedicion.Add(VariableMedicion);
            gcVariablesDeMedicion.DataSource = VariableMedicion;
            gcVariablesDeMedicion.RefreshDataSource();

            SetearTotales();
        }
    }
}