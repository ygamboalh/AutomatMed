using Nagaira.Herramientas.Standard.Helpers.Requests;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Libs.Dtos;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;
using MessageBox = System.Windows.Forms.MessageBox;

namespace AutomatMediciones.DesktopApp.Pantallas.Diagnosticos
{
    public partial class frmDiagnosticos : DevExpress.XtraEditors.XtraForm
    {
        string rutaApi;
        ICollection<IngresoDto> ingresos = new List<IngresoDto>();
        public frmDiagnosticos()
        {
            InitializeComponent();

            rutaApi = AplicacionHelper.ObtenerRutaApiDeAplicacion();
            EstablecerNombreYTitulo();
            CargarIngresos();

            btnIniciarDiagnostico.Click += btnIniciarDiagnosticoClick;

        }

        private void btnIniciarDiagnosticoClick(object sender, EventArgs e)
        {
            GridView view = this.gridControl1.Views[1] as GridView;
            if (view != null)
            {

                var fila = view.GetFocusedRow() as IngresoInstrumento;
            }
        }

        private async void CargarIngresos()
        {
            try
            {
                string uri = "/ingresos";
                var ingresosRespuesta = await HttpHelper.Get<IngresoDto>(rutaApi, uri, "");
                ingresos = ingresosRespuesta;

                List<Ingreso> ingresosLista = new List<Ingreso>();

                var detalle = ingresos.SelectMany(x => x.IngresosInstrumentos).ToList();
                foreach (var ingreso in ingresos)
                {
                    var nuevoIngreso = new Ingreso
                    {
                        Id = ingreso.IngresoId,
                        Estado = ingreso.Estado.Descripcion,
                        Fecha = ingreso.FechaRegistro,
                        NombreEmpresa = ingreso.NombreEmpresa,
                        Prioridad = ingreso.Prioridad,
                        Instrumentos = detalle.Where(x => x.IngresoId == ingreso.IngresoId).Select(y => new IngresoInstrumento
                        {
                            IngresoId = y.IngresoId,
                            IngresoInstrumentoId = y.IngresoInstrumentoId,
                            DescripcionInstrumento = y.Instrumento.Descripcion,
                            InstrumentoId = y.InstrumentoId,
                            Marca = y.Instrumento.Clasificacion.Marca.Descripcion,
                            Modelo = y.Instrumento.Clasificacion.Modelo.Descripcion,
                            TipoInstrumento = y.Instrumento.Clasificacion.TipoInstrumento.Descripcion
                        }).ToList()
                    };

                    ingresosLista.Add(nuevoIngreso);
                }

                gridControl1.DataSource = ingresosLista;
                ExpandAllRows(gvIngresos);

                SetearTotales();
            }
            catch (Exception exc)
            {
                string message = exc.InnerException == null ? exc.Message : exc.InnerException.Message;
                MessageBox.Show(message, "Tactica Reparaciones", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Error);
            }
        }

        public void ExpandAllRows(GridView View)
        {
            View.BeginUpdate();
            try
            {
                int dataRowCount = View.DataRowCount;
                for (int rHandle = 0; rHandle < dataRowCount; rHandle++)
                    View.SetMasterRowExpanded(rHandle, true);
            }
            finally
            {
                View.EndUpdate();
            }
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {ingresos.Count}";
            lblTotal.Visible = true;
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla1.lblTitulo.Text = "Diagnósticos";
            ctlEncabezadoPantalla1.EstablecerColoresDeFondoYLetra();
        }
    }
}