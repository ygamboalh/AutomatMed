using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Libs.Dtos;

namespace AutomatMediciones.DesktopApp.Pantallas.VariablesDeMedicion
{
    public partial class frmVariablesDeMedicion : DevExpress.XtraEditors.XtraForm
    {
        string rutaApi;
        ICollection<VariableMedicionDto> variablesDeMedicion = new List<VariableMedicionDto>();

        public frmVariablesDeMedicion()
        {
            InitializeComponent();
            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();
            EstablecerNombreYTitulo();
            EstablecerColorBotonPorDefecto();
            CargarVariablesDeMedicion();

            cmdEditar.Click += OnSeleccionaVariableMedicionParaModificar;
        }

        private void OnSeleccionaVariableMedicionParaModificar(object sender, EventArgs e)
        {
            var VariableMedicion = gvVariablesDeMedicion.GetFocusedRow() as VariableMedicionDto;
            frmNuevaVariableMedicion frmNuevaVariableMedicion = new frmNuevaVariableMedicion(TipoTransaccion.Actualizar);
            frmNuevaVariableMedicion.NuevaVariableMedicion = VariableMedicion;
            frmNuevaVariableMedicion.SetearValoresParaActualizar();
            frmNuevaVariableMedicion.OnVariableMedicionModificada += OnVariableMedicionModificada;
            frmNuevaVariableMedicion.Show();
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
            ctlEncabezadoPantalla3.lblTitulo.Text = "Variables de Medición";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonPorDefecto()
        {
            btnAgregarNuevInstrumento.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnAgregarNuevInstrumento.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarNuevInstrumento.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private async void CargarVariablesDeMedicion()
        {
            string uri = "/variables-de-medicion";
            var variableMedicionsRespuesta = await HttpHelper.Get<VariableMedicionDto>(rutaApi, uri, "");
            variablesDeMedicion = variableMedicionsRespuesta;

            gcVariablesDeMedicion.DataSource = variablesDeMedicion;

            SetearTotales();
        }

        private void btnAgregarNuevInstrumento_Click(object sender, System.EventArgs e)
        {
            frmNuevaVariableMedicion frmNuevaVariableMedicion = new frmNuevaVariableMedicion(TipoTransaccion.Insertar);
            frmNuevaVariableMedicion.OnVariableMedicionAgregada += OnVariableMedicionAgregada;
            frmNuevaVariableMedicion.Show();
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