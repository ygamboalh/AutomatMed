using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Marcas;
using AutomatMediciones.DesktopApp.Pantallas.Modelos;
using AutomatMediciones.DesktopApp.Pantallas.TiposDeInstrumento;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Core.Extentions.Enumeradores;
using Nagaira.Core.Extentions.Responses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Clasificaciones
{
    public partial class frmNuevaClasificacion : DevExpress.XtraEditors.XtraForm
    {
        public delegate void ClasificacionInstrumentoAgregada(ClasificacionInstrumentoDto tipoInstrumento);
        public event ClasificacionInstrumentoAgregada OnClasificacionInstrumentoAgregada;

        public delegate void ClasificacionInstrumentoModificada(ClasificacionInstrumentoDto tipoInstrumento);
        public event ClasificacionInstrumentoModificada OnClasificacionInstrumentoModificada;



        private readonly ClasificacionInstrumentoService _clasificacionInstrumentoService;
        private readonly MarcaService _marcaService;
        private readonly ModeloService _modeloService;
        private readonly TipoDeInstrumentoService _tipoDeInstrumentoService;

        public TipoTransaccion TipoTransaccion { get; set; }

        private ServiceProvider serviceProvider = Program.services.BuildServiceProvider();

        public ICollection<ModeloDto> Modelos = new List<ModeloDto>();
        public ICollection<MarcaDto> Marcas = new List<MarcaDto>();
        public ICollection<TipoInstrumentoDto> TiposDeInstrumento = new List<TipoInstrumentoDto>();

        public ClasificacionInstrumentoDto NuevaClasificacion { get; set; }
        public frmNuevaClasificacion(TipoTransaccion tipoTransaccion, ClasificacionInstrumentoService clasificacionInstrumentoService, MarcaService marcaService, ModeloService modeloService, TipoDeInstrumentoService tipoDeInstrumentoService)
        {
            InitializeComponent();
            TipoTransaccion = tipoTransaccion;
            _clasificacionInstrumentoService = clasificacionInstrumentoService;
            _marcaService = marcaService;
            _modeloService = modeloService;
            _tipoDeInstrumentoService = tipoDeInstrumentoService;
            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonGuardar();

            NuevaClasificacion = new ClasificacionInstrumentoDto();

        }

        public void InicializarMaestros()
        {
            lookupMarca.Properties.DataSource = Marcas;
            lookupModelo.Properties.DataSource = Modelos;
            lookupTipoInstrumento.Properties.DataSource = TiposDeInstrumento;

            lookupMarca.Properties.DisplayMember = "Descripcion";
            lookupMarca.Properties.ValueMember = "MarcaId";

            lookupModelo.Properties.DisplayMember = "Descripcion";
            lookupModelo.Properties.ValueMember = "ModeloId";

            lookupTipoInstrumento.Properties.DisplayMember = "Descripcion";
            lookupTipoInstrumento.Properties.ValueMember = "TipoInstrumentoId";
        }

        public void SetearValoresParaActualizar()
        {
            lookupModelo.EditValue = NuevaClasificacion.ModeloId;
            lookupMarca.EditValue = NuevaClasificacion.MarcaId;
            lookupTipoInstrumento.EditValue = NuevaClasificacion.TipoInstrumentoId;
            nmPeriodoCalibracion.Value = NuevaClasificacion.PeriodoDeCalibracion;
        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            this.Text = "";
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = TipoTransaccion == TipoTransaccion.Insertar ? "Agregar Clasificación  de Instrumento" : "Modificar Clasificación de Instrumento";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
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
            NuevaClasificacion.TipoInstrumentoId = (int)lookupTipoInstrumento.EditValue;
            NuevaClasificacion.MarcaId = (int)lookupMarca.EditValue;
            NuevaClasificacion.ModeloId = (int)lookupModelo.EditValue;
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

        private void btnNuevaClasificacion_Click(object sender, EventArgs e)
        {
            var frmTipoInstrumento = new frmNuevoTipoInstrumento(TipoTransaccion.Insertar, serviceProvider.GetService<TipoDeInstrumentoService>());
            frmTipoInstrumento.OnTipoInstrumentoAgregado += OnTipoInstrumentoAgregado;
            frmTipoInstrumento.ShowDialog();
        }

        private void OnTipoInstrumentoAgregado(TipoInstrumentoDto tipoInstrumento)
        {
            serviceProvider = Program.services.BuildServiceProvider();
            TiposDeInstrumento = _tipoDeInstrumentoService.ObtenerTiposDeInstrumento().Data;
            lookupTipoInstrumento.Properties.DataSource = TiposDeInstrumento;
            this.Focus();
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            var frmNuevaMarca = new frmNuevaMarca(TipoTransaccion.Insertar, serviceProvider.GetService<MarcaService>());
            frmNuevaMarca.OnMarcaAgregada += OnMarcaAgregada;
            frmNuevaMarca.ShowDialog();
        }

        private void OnMarcaAgregada(MarcaDto tipoInstrumento)
        {
            serviceProvider = Program.services.BuildServiceProvider();
            Marcas = _marcaService.ObtenerMarcas().Data;
            lookupMarca.Properties.DataSource = Marcas;
            this.Focus();
        }

        private void btnNuevoModelo_Click(object sender, EventArgs e)
        {
            var frmNuevoModelo = new frmNuevoModelo(TipoTransaccion.Insertar,
                                                    serviceProvider.GetService<ModeloService>(),
                                                    serviceProvider.GetService<CeldaService>());

            frmNuevoModelo.OnModeloAgregada += OnModeloAgregada;
            frmNuevoModelo.ShowDialog();
        }

        private void OnModeloAgregada(ModeloDto modelo)
        {
            serviceProvider = Program.services.BuildServiceProvider();
            Modelos = _modeloService.ObtenerModelos().Data;
            lookupModelo.Properties.DataSource = Modelos;
            this.Focus();
        }
    }
}