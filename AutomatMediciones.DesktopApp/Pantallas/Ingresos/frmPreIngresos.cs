using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Diagnosticos.Dtos;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Ingresos
{
    public partial class frmPreIngresos : DevExpress.XtraEditors.XtraForm
    {
        List<IngresoInstrumento> preIngresosSeleccionados;
        public delegate void IngresosAgregados(List<IngresoInstrumento> ingresos);
        public event IngresosAgregados OnIngresosAgregados;

        public frmPreIngresos(List<IngresoInstrumento> preIngresos, bool esParaAgregar = true)
        {
            InitializeComponent();

            preIngresosSeleccionados = new List<IngresoInstrumento>();

            pnlBtnAgregar.Visible = esParaAgregar;
            colSeleccionar.Visible = esParaAgregar;

            if (esParaAgregar)
            {
                PrepararDataSourcePreIngresos(preIngresos);
            }

            SetearTotales();

            EstablecerNombreYTituloDePantalla();
            EstablecerColorBotonGuardar();

            chkSeleccionar.CheckedChanged += onSeleccionaInstrumentoPreIngreso;
        }

        private void onSeleccionaInstrumentoPreIngreso(object sender, EventArgs e)
        {
            var check = sender as CheckEdit;

            var ingresoSeleccionao = gvPreIngresos.GetFocusedRow() as IngresoInstrumento;
            if (ingresoSeleccionao == null) return;

            ingresoSeleccionao.PreIngresoId = ingresoSeleccionao.IngresoId;
            ingresoSeleccionao.Seleccionado = (bool)check.EditValue;

            if (!ingresoSeleccionao.Seleccionado)
            {
                preIngresosSeleccionados = preIngresosSeleccionados.Where(x => x.IngresoInstrumentoId != ingresoSeleccionao.IngresoInstrumentoId).ToList();
                SetearTotales();
                return;
            }

            preIngresosSeleccionados.Add(ingresoSeleccionao);
            SetearTotales();
        }

        private void PrepararDataSourcePreIngresos(List<IngresoInstrumento> preIngresos)
        {
            gcPreIngresos.DataSource = preIngresos;
            gcPreIngresos.RefreshDataSource();
        }

        private void EstablecerNombreYTituloDePantalla()
        {

            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Pre-Ingresos";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }

        private void EstablecerColorBotonGuardar()
        {
            btnAgregarPreIngreso.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnAgregarPreIngreso.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarPreIngreso.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void btnAgregarPreIngreso_Click(object sender, EventArgs e)
        {
            if (preIngresosSeleccionados.Count == 0)
            {
                Notificaciones.MensajeAdvertencia($"¡Es necesario que seleccione al menos un instrumento Pre-Ingresado!");
                return;
            }

            OnIngresosAgregados?.Invoke(preIngresosSeleccionados);
            this.Close();

        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {gvPreIngresos.RowCount}";
            lblTotal.Visible = true;

            lblIntrumentosSeleccionados.Text = $"Total Seleccionados: {preIngresosSeleccionados.Count}";
            lblIntrumentosSeleccionados.Visible = true;
        }
    }
}