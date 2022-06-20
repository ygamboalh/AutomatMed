using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Celdas
{
    public partial class frmNuevaCelda : DevExpress.XtraEditors.XtraForm
    {
        private readonly CeldaService _celdaService;

        public delegate void CeldaAgregada(CeldaDto celda);
        public event CeldaAgregada OnCeldaAgregada;

        public delegate void CeldaModificada(CeldaDto celda);
        public event CeldaModificada OnCeldaModificada;


        public TipoTransaccion TipoTransaccion { get; set; }
        public CeldaDto NuevaCelda { get; set; }

        public frmNuevaCelda(TipoTransaccion tipoTransaccion, CeldaService celdaService)
        {
            InitializeComponent();
            TipoTransaccion = tipoTransaccion;
            _celdaService = celdaService;

            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonGuardar();

            CargarTiposDeCeldas();
            NuevaCelda = new CeldaDto();

        }

        private void CargarTiposDeCeldas()
        {
            var resultado = _celdaService.ObtenerTiposDeCeldas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            glTipoCelda.Properties.DataSource = resultado.Data;

            glTipoCelda.Properties.DisplayMember = "Descripcion";
            glTipoCelda.Properties.ValueMember = "Id";
        }


        public void SetearValoresParaActualizar()
        {
            txtNumeroSerie.Text = NuevaCelda.NumeroSerie;
            txtEstado.Text = NuevaCelda.Estado;
            glTipoCelda.EditValue = NuevaCelda.TipoCeldaId;
            dateFechaAdquisicion.EditValue = NuevaCelda.FechaAdquisicion.HasValue ? NuevaCelda.FechaAdquisicion.Value : null;
            dateFechaFabricacion.EditValue = NuevaCelda.FechaFabricacion.HasValue ? NuevaCelda.FechaFabricacion.Value : null;

        }

        private void PrepararNuevaCelda()
        {
            NuevaCelda.TipoCeldaId = (int)glTipoCelda.EditValue;
            NuevaCelda.NumeroSerie = txtNumeroSerie.Text;
            NuevaCelda.FechaFabricacion = dateFechaFabricacion.EditValue != null ? (DateTime)dateFechaFabricacion.EditValue : null;
            NuevaCelda.FechaAdquisicion = dateFechaAdquisicion.EditValue != null ? (DateTime)dateFechaAdquisicion.EditValue : null;
            NuevaCelda.Estado = txtEstado.Text;
        }


        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = TipoTransaccion == TipoTransaccion.Insertar ? "Agregar Celda" : "Modificar Celda";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarCelda.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarCelda.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarCelda.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private bool GuardarCelda()
        {
            try
            {
                var resultado = _celdaService.RegistrarCelda(NuevaCelda);
                if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private bool ActualizarCelda()
        {
            try
            {
                var resultado = _celdaService.ActualizarMarca(NuevaCelda);
                if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void btnGuardarCelda_Click(object sender, EventArgs e)
        {
            PrepararNuevaCelda();

            if (!EsValidaLaInformacionIngresadaParaNuevaCelda(out string mensaje))
            {
                Notificaciones.MensajeAdvertencia(mensaje);
                return;
            }

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));
            if (TipoTransaccion == TipoTransaccion.Insertar)
            {
                if (GuardarCelda())
                {
                    Notificaciones.MensajeConfirmacion("¡La celda se ha registrado exitosamente!");
                    OnCeldaAgregada?.Invoke(NuevaCelda);
                    this.Close();
                }
            }
            else
            {
                if (ActualizarCelda())
                {

                    Notificaciones.MensajeConfirmacion("¡La celda se ha actualizado exitosamente!");
                    OnCeldaModificada?.Invoke(NuevaCelda);
                    this.Close();
                }
            }

            SplashScreenManager.CloseForm();

        }

        private bool EsValidaLaInformacionIngresadaParaNuevaCelda(out string mensaje)
        {
            if (string.IsNullOrEmpty(NuevaCelda.NumeroSerie))
            {
                mensaje = "Es necesario ingresar una serie para la celda.";
                return false;
            }
            mensaje = "Ok";
            return true;
        }
    }
}