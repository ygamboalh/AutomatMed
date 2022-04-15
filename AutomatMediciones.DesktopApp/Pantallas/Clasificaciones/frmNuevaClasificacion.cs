using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;

namespace AutomatMediciones.DesktopApp.Pantallas.Clasificaciones
{
    public partial class frmNuevaClasificacion : DevExpress.XtraEditors.XtraForm
    {
        public delegate void ClasificacionInstrumentoAgregada(ClasificacionInstrumentoDto tipoInstrumento);
        public event ClasificacionInstrumentoAgregada OnClasificacionInstrumentoAgregada;

        public delegate void ClasificacionInstrumentoModificada(ClasificacionInstrumentoDto tipoInstrumento);
        public event ClasificacionInstrumentoModificada OnClasificacionInstrumentoModificada;

        private readonly ClasificacionInstrumentoService _clasificacionInstrumentoService;

        public TipoTransaccion TipoTransaccion { get; set; }

        public ICollection<ModeloDto> Modelos = new List<ModeloDto>();
        public ICollection<MarcaDto> Marcas = new List<MarcaDto>();
        public ICollection<TipoInstrumentoDto> TiposDeInstrumento = new List<TipoInstrumentoDto>();

        public ClasificacionInstrumentoDto NuevaClasificacion { get; set; }
        public frmNuevaClasificacion(TipoTransaccion tipoTransaccion, ClasificacionInstrumentoService clasificacionInstrumentoService)
        {
            InitializeComponent();
            TipoTransaccion = tipoTransaccion;
            _clasificacionInstrumentoService = clasificacionInstrumentoService;

            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonGuardar();

            NuevaClasificacion = new ClasificacionInstrumentoDto();

        }

        public void InicializarMaestros()
        {
            glMarca.Properties.DataSource = Marcas;
            glModelo.Properties.DataSource = Modelos;
            glTipoInstrumento.Properties.DataSource = TiposDeInstrumento;

            glMarca.Properties.DisplayMember = "Descripcion";
            glMarca.Properties.ValueMember = "MarcaId";

            glModelo.Properties.DisplayMember = "Descripcion";
            glModelo.Properties.ValueMember = "ModeloId";

            glTipoInstrumento.Properties.DisplayMember = "Descripcion";
            glTipoInstrumento.Properties.ValueMember = "TipoInstrumentoId";
        }

        public void SetearValoresParaActualizar()
        {
            glModelo.EditValue = NuevaClasificacion.ModeloId;
            glMarca.EditValue = NuevaClasificacion.MarcaId;
            glTipoInstrumento.EditValue = NuevaClasificacion.TipoInstrumentoId;
            nmPeriodoCalibracion.Value = NuevaClasificacion.PeriodoDeCalibracion;
        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            this.Text = "";
            ctlEncabezadoPantalla1.lblTitulo.Text = TipoTransaccion == TipoTransaccion.Insertar ? "Agregar Clasificación  de Instrumento" : "Modificar Clasificación de Instrumento";
            ctlEncabezadoPantalla1.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarClasificacion.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarClasificacion.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarClasificacion.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private bool GuardarClasificacionInstrumento()
        {

            try
            {
                var resultado = _clasificacionInstrumentoService.RegistrarClasificacion(NuevaClasificacion);
                if (resultado.Type != TypeResponse.Ok) return false;

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private bool ActualizarClasificacionInstrumento()
        {
            try
            {
                var resultado = _clasificacionInstrumentoService.ActualizarClasificacion(NuevaClasificacion);
                if (resultado.Type != TypeResponse.Ok) return false;

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void PrepararNuevaClasificacionInstrumento()
        {
            NuevaClasificacion.TipoInstrumentoId = (int)glTipoInstrumento.EditValue;
            NuevaClasificacion.MarcaId = (int)glMarca.EditValue;
            NuevaClasificacion.ModeloId = (int)glModelo.EditValue;
            NuevaClasificacion.PeriodoDeCalibracion = (int)nmPeriodoCalibracion.Value;
        }


        private bool EsValidaLaInformacionIngresadaParaNuevaClasificacion(out string mensaje)
        {
            if (NuevaClasificacion.TipoInstrumentoId == 0)
            {
                mensaje = "Es necesario ingresar un Tipo de Instrumento para la Clasificación del Instrumento.";
                return false;
            }
            if (NuevaClasificacion.MarcaId == 0)
            {
                mensaje = "Es necesario ingresar una Marca para la Clasificación del Instrumento.";
                return false;
            }
            if (NuevaClasificacion.ModeloId == 0)
            {
                mensaje = "Es necesario ingresar un Modelo para la Clasificación del Instrumento.";
                return false;
            }
            mensaje = "Ok";
            return true;
        }

        private void btnGuardarClasificacionInstrumento_Click(object sender, EventArgs e)
        {
            PrepararNuevaClasificacionInstrumento();

            if (!EsValidaLaInformacionIngresadaParaNuevaClasificacion(out string mensaje))
            {
                Notificaciones.MensajeAdvertencia(mensaje);
                return;
            }

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));
            if (TipoTransaccion == TipoTransaccion.Insertar)
            {
                if ((GuardarClasificacionInstrumento()))
                {
                    Notificaciones.MensajeConfirmacion("¡La Clasificación de Instrumento se ha registrado exitosamente!");
                    OnClasificacionInstrumentoAgregada?.Invoke(NuevaClasificacion);
                    this.Close();
                }
            }
            else
            {
                if (ActualizarClasificacionInstrumento())
                {
                    Notificaciones.MensajeConfirmacion("¡La Clasificación de Instrumento se ha actualizado exitosamente!");
                    OnClasificacionInstrumentoModificada?.Invoke(NuevaClasificacion);
                    this.Close();
                }
            }
            SplashScreenManager.CloseForm();
        }
    }
}