using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.VariablesDeMedicion;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.TiposDeCelda
{
    public partial class frmNuevoTIpoCelda : DevExpress.XtraEditors.XtraForm
    {
        private readonly CeldaService _celdaService;
        private readonly VariableMedicionService _variableMedicionService;

        public delegate void TipoCeldaAgregada(TipoCeldaDto tipoCelda);
        public event TipoCeldaAgregada OnTipoCeldaAgregada;

        public delegate void MarcaModificada(MarcaDto tipoInstrumento);
        public event MarcaModificada OnTipoCeldaModificada;

        private ServiceProvider serviceProvider = Program.services.BuildServiceProvider();

        public TipoTransaccion TipoTransaccion { get; set; }
        public TipoCeldaDto NuevoTipoCelda { get; set; }

        public frmNuevoTIpoCelda(TipoTransaccion tipoTransaccion, CeldaService celdaService, VariableMedicionService variableMedicionService)
        {
            InitializeComponent();

            TipoTransaccion = tipoTransaccion;
            _celdaService = celdaService;
            _variableMedicionService = variableMedicionService;
            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonGuardar();
            CargarVariablesDeMedicion();
            NuevoTipoCelda = new TipoCeldaDto();
        }

        public void SetearValoresParaActualizar()
        {
            txtDescripcion.Text = NuevoTipoCelda.Descripcion;
            glVariablesDeMedicion.EditValue = NuevoTipoCelda.VariableMedicionId;
        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = TipoTransaccion == TipoTransaccion.Insertar ? "Agregar Tipo de Celda" : "Modificar Tipo de Celda";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarTipoCelda.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarTipoCelda.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarTipoCelda.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void CargarVariablesDeMedicion()
        {
            var resultado = _variableMedicionService.ObtenerVariablesDeMedicionActivas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            glVariablesDeMedicion.Properties.DataSource = resultado.Data;
            glVariablesDeMedicion.Properties.DisplayMember = "Descripcion";
            glVariablesDeMedicion.Properties.ValueMember = "VariableMedicionId";
        }

        private bool EsValidaLaInformacionIngresadaParaNuevoTipoDeCelda(out string mensaje)
        {
            if (string.IsNullOrEmpty(NuevoTipoCelda.Descripcion))
            {
                mensaje = "Es necesario ingresar un nombre para el tipo de celda.";
                return false;
            }

            mensaje = "Ok";
            return true;
        }

        private void PrepararNuevoTipoDeCelda()
        {
            NuevoTipoCelda.Descripcion = txtDescripcion.Text;
            NuevoTipoCelda.VariableMedicionId = (int)glVariablesDeMedicion.EditValue;

        }

        private bool GuardarTipoDeCelda()
        {
            try
            {
                var resultado = _celdaService.RegistrarTipoDeCelda(NuevoTipoCelda);
                if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private bool ActualizarTipoDeCelda()
        {
            try
            {
                var resultado = _celdaService.ActualizarTipoDeCelda(NuevoTipoCelda);
                if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }


        private void btnGuardarTipoCelda_Click(object sender, EventArgs e)
        {
            PrepararNuevoTipoDeCelda();
            if (!EsValidaLaInformacionIngresadaParaNuevoTipoDeCelda(out string mensaje))
            {
                Notificaciones.MensajeAdvertencia(mensaje);
                return;
            }

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));
            if (TipoTransaccion == TipoTransaccion.Insertar)
            {
                if (GuardarTipoDeCelda())
                {
                    Notificaciones.MensajeConfirmacion("¡El tipo de celda se ha registrado exitosamente!");
                    OnTipoCeldaAgregada?.Invoke(NuevoTipoCelda);
                    this.Close();
                }

            }
            else
            {
                if (ActualizarTipoDeCelda())
                {
                    Notificaciones.MensajeConfirmacion("¡El tipo de celda se ha actualizado exitosamente!");
                    OnTipoCeldaAgregada?.Invoke(NuevoTipoCelda);
                    this.Close();
                }
            }

            SplashScreenManager.CloseForm();
        }

        private void btnNuevaVariableMedicion_Click(object sender, EventArgs e)
        {
            var frmNuevaVariableMedicion = new frmNuevaVariableMedicion(TipoTransaccion.Insertar, serviceProvider.GetService<VariableMedicionService>(), 
                serviceProvider.GetService<TipoDeInstrumentoService>(), serviceProvider.GetService<UnidadMedidaService>());
            frmNuevaVariableMedicion.OnVariableMedicionAgregada += OnVariableMedicionAgregada;
            frmNuevaVariableMedicion.ShowDialog();
        }

        private void OnVariableMedicionAgregada(VariableMedicionDto tipoInstrumento)
        {
            CargarVariablesDeMedicion();
        }
    }
}