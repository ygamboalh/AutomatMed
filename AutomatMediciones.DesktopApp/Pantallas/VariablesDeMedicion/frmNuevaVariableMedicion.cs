using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.VariablesDeMedicion
{
    public partial class frmNuevaVariableMedicion : DevExpress.XtraEditors.XtraForm
    {
        private readonly VariableMedicionService _variableMedicionService;
        private readonly TipoDeInstrumentoService _tipoinstrumentoService;

        public delegate void VariableMedicionAgregada(VariableMedicionDto tipoInstrumento);
        public event VariableMedicionAgregada OnVariableMedicionAgregada;

        public delegate void VariableMedicionModificada(VariableMedicionDto tipoInstrumento);
        public event VariableMedicionModificada OnVariableMedicionModificada;

        public TipoTransaccion TipoTransaccion { get; set; }

        public VariableMedicionDto NuevaVariableMedicion { get; set; }
        public frmNuevaVariableMedicion(TipoTransaccion tipoTransaccion, VariableMedicionService variableMedicionService, TipoDeInstrumentoService tipoinstrumentoService)
        {
            InitializeComponent();
            TipoTransaccion = tipoTransaccion;
            _variableMedicionService = variableMedicionService;
            _tipoinstrumentoService = tipoinstrumentoService;

            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonGuardar();

            NuevaVariableMedicion = new VariableMedicionDto();
            CargarTiposDeInstrumentos();
            btnEliminar.Click += onClickBotonEliminar;

        }

        private void onClickBotonEliminar(object sender, EventArgs e)
        {
            var tipoInstrumentoVariableSeleccionado = gvTiposDeInstrumento.GetFocusedRow() as TipoInstrumentoVariableDto;
            NuevaVariableMedicion.TiposDeInstrumentoVariables = NuevaVariableMedicion.TiposDeInstrumentoVariables
                                                                                     .Where(x => x.TipoInstrumentoId == tipoInstrumentoVariableSeleccionado.TipoInstrumentoId).ToList();

            AsignarTotales();
        }

        public void SetearValoresParaActualizar()
        {
            txtDescripcion.Text = NuevaVariableMedicion.Descripcion;
            nmPrimerValorRango.Value = NuevaVariableMedicion.PrimerValorRango;
            nmSegundoValorRango.Value = NuevaVariableMedicion.SegundoValorRango;
            nmTolerancia.Value = NuevaVariableMedicion.Tolerancia;
            txtDescripcionCorta.Text = NuevaVariableMedicion.DescripcionCorta;
            txtNombre.Text = NuevaVariableMedicion.Nombre;

            if (NuevaVariableMedicion.TiposDeInstrumentoVariables.Any())
            {
                gcTiposDeInstrumento.DataSource = NuevaVariableMedicion.TiposDeInstrumentoVariables;
            }

        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            this.Text = "";
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = TipoTransaccion == TipoTransaccion.Insertar ? "Agregar Variable de Medición" : "Modificar Variable de Medición";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarVariableMedicion.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarVariableMedicion.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarVariableMedicion.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private bool GuardarVariableMedicion()
        {

            try
            {
                var resultado = _variableMedicionService.RegistrarVariableDeMedicion(NuevaVariableMedicion);
                if (resultado.Type != TypeResponse.Ok) return false;

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void CargarTiposDeInstrumentos()
        {
            var resultado = _tipoinstrumentoService.ObtenerTiposDeInstrumento();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            leTipInstrumento.Properties.DataSource = resultado.Data;
            leTipInstrumento.Properties.DisplayMember = "Descripcion";
            leTipInstrumento.Properties.ValueMember = "TipoInstrumentoId";
        }

        private bool ActualizarVariableMedicion()
        {

            try
            {
                var resultado = _variableMedicionService.ActualizarVariableDeMedicion(NuevaVariableMedicion);
                if (resultado.Type != TypeResponse.Ok) return false;

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void PrepararNuevaVariableMedicion()
        {
            NuevaVariableMedicion.Descripcion = txtDescripcion.Text;
            NuevaVariableMedicion.PrimerValorRango = nmPrimerValorRango.Value;
            NuevaVariableMedicion.SegundoValorRango = nmSegundoValorRango.Value;
            NuevaVariableMedicion.Tolerancia = nmTolerancia.Value;
            NuevaVariableMedicion.DescripcionCorta = txtDescripcionCorta.Text;
            NuevaVariableMedicion.Nombre = txtNombre.Text;
        }


        private bool EsValidaLaInformacionIngresadaParaNuevoTipoInstrumento(out string mensaje)
        {
            if (string.IsNullOrEmpty(NuevaVariableMedicion.Descripcion))
            {
                mensaje = "Es necesario ingresar una descripción para la Variable de Medición.";
                return false;
            }
            mensaje = "Ok";
            return true;
        }

        private void btnGuardarVariableMedicion_Click(object sender, EventArgs e)
        {
            PrepararNuevaVariableMedicion();

            if (!EsValidaLaInformacionIngresadaParaNuevoTipoInstrumento(out string mensaje))
            {
                Notificaciones.MensajeAdvertencia(mensaje);
                return;
            }

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));
            if (TipoTransaccion == TipoTransaccion.Insertar)
            {
                if (GuardarVariableMedicion())
                {
                    Notificaciones.MensajeConfirmacion("¡La Variable de Medición se ha registrado exitosamente!");
                    OnVariableMedicionAgregada?.Invoke(NuevaVariableMedicion);
                    this.Close();
                }
            }
            else
            {
                if (ActualizarVariableMedicion())
                {
                    Notificaciones.MensajeConfirmacion("¡La Variable de Medición se ha actualizado exitosamente!");
                    OnVariableMedicionModificada?.Invoke(NuevaVariableMedicion);
                    this.Close();
                }
            }

            SplashScreenManager.CloseForm();
        }

        private void btnAgregarTipoDeInstrumento_Click(object sender, EventArgs e)
        {
            if (leTipInstrumento.EditValue == null)
            {
                Notificaciones.MensajeAdvertencia("Es necesario que seleccione un tipo de instrumento para continuar.");
                return;
            }

            if (NuevaVariableMedicion.TiposDeInstrumentoVariables == null)
            {
                NuevaVariableMedicion.TiposDeInstrumentoVariables = new List<TipoInstrumentoVariableDto>();
            }

            var tipoInstrumentoSeleccionado = leTipInstrumento.GetSelectedDataRow() as TipoInstrumentoDto;
            var existeEnLista = NuevaVariableMedicion.TiposDeInstrumentoVariables.Any(x => x.TipoInstrumentoId == tipoInstrumentoSeleccionado.TipoInstrumentoId);

            if (existeEnLista)
            {
                Notificaciones.MensajeAdvertencia("Este tipo de instrumento ya está agregado en la lista.");
                return;
            }

            NuevaVariableMedicion.TiposDeInstrumentoVariables.Add(new TipoInstrumentoVariableDto
            {
                TipoInstrumentoId = tipoInstrumentoSeleccionado.TipoInstrumentoId,
                TipoInstrumento = tipoInstrumentoSeleccionado
            });

            AsignarTotales();
        }

        private void AsignarTotales()
        {
            gcTiposDeInstrumento.DataSource = NuevaVariableMedicion.TiposDeInstrumentoVariables;
            gcTiposDeInstrumento.RefreshDataSource();

            lblTotalInstrumentos.Visible = true;
            lblTotalInstrumentos.Text = $"Total Instrumentos: {NuevaVariableMedicion.TiposDeInstrumentoVariables.Count}";
        }

        private void btnAgregarTipoDeInstrumento_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(btnVincularVariableMedicion, "Presione para agregar a lista de instrumentos asociados.");
        }
    }
}