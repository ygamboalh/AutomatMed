using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Nagaira.Core.Extentions.Enumeradores;
using Nagaira.Core.Extentions.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Modelos
{
    public partial class frmNuevoModelo : DevExpress.XtraEditors.XtraForm
    {
        private readonly ModeloService _modeloService;
        private readonly CeldaService _celdaService;

        public delegate void ModeloAgregada(ModeloDto modelo);
        public event ModeloAgregada OnModeloAgregada;

        public delegate void ModeloModificada(ModeloDto modelo);
        public event ModeloModificada OnModeloModificada;

        public TipoTransaccion TipoTransaccion { get; set; }
        List<TipoCeldaDto> tiposDeCeldas = new List<TipoCeldaDto>();
        public ModeloDto NuevoModelo { get; set; }



        public frmNuevoModelo(TipoTransaccion tipoTransaccion, ModeloService modeloService, CeldaService celdaService)
        {
            InitializeComponent();

            TipoTransaccion = tipoTransaccion;
            _modeloService = modeloService;
            _celdaService = celdaService;

            EstablecerNombreYTituloPopupAgregarInstrumentos();
            EstablecerColorBotonGuardar();
            CargarTiposDeCelda();

            NuevoModelo = new ModeloDto();


            btnEliminar.Click += btnEliminarClick;

        }

        private void btnEliminarClick(object sender, EventArgs e)
        {
            var filaSeleccionda = gvTiposDeCeldaModelo.GetFocusedRow() as TipoCeldaModeloDto;
            if (filaSeleccionda == null) return;

            if (filaSeleccionda.Id == 0)
            {
                NuevoModelo.TipoCeldaModelo = NuevoModelo.TipoCeldaModelo.Where(x => x.Id != filaSeleccionda.Id).ToList();
                gcTiposDeCeldaModelo.DataSource = NuevoModelo.TipoCeldaModelo;
                gcTiposDeCeldaModelo.RefreshDataSource();

                SetearTotales();
                return;
            }


            if (DesactivarTipoCeldaModelo(filaSeleccionda.Id))
            {
                NuevoModelo.TipoCeldaModelo = NuevoModelo.TipoCeldaModelo.Where(x => x.Id != filaSeleccionda.Id).ToList();
                gcTiposDeCeldaModelo.DataSource = NuevoModelo.TipoCeldaModelo;
                gcTiposDeCeldaModelo.RefreshDataSource();

                SetearTotales();
            }

        }

        public void SetearValoresParaActualizar()
        {
            txtDescripcion.Text = NuevoModelo.Descripcion;

            gcTiposDeCeldaModelo.DataSource = NuevoModelo.TipoCeldaModelo;
            gcTiposDeCeldaModelo.RefreshDataSource();

            SetearTotales();
        }

        private void EstablecerNombreYTituloPopupAgregarInstrumentos()
        {
            this.Text = "";

            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = TipoTransaccion == TipoTransaccion.Insertar ? "Agregar Modelo" : "Modificar Modelo";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }
        private void EstablecerColorBotonGuardar()
        {
            btnGuardarModelo.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarModelo.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarModelo.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void CargarTiposDeCelda()
        {
            var resultado = _celdaService.ObtenerTiposDeCeldas();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var tiposDeCeldaRespuesta = resultado.Data;
            tiposDeCeldas = tiposDeCeldaRespuesta;

            leTipoCelda.Properties.DataSource = tiposDeCeldas;
            leTipoCelda.Properties.DisplayMember = "Descripcion";
            leTipoCelda.Properties.ValueMember = "Id";
        }

        private void SetearTotales()
        {
            lblTotal.Text = $"Total Registros: {NuevoModelo.TipoCeldaModelo.Count}";
            lblTotal.Visible = true;
        }

        private bool GuardarModelo()
        {
            try
            {
                var resultado = _modeloService.RegistrarModelo(NuevoModelo);
                if (resultado.Type != TypeResponse.Ok)
                {
                    Notificaciones.MensajeError(resultado.Message);
                    return false;
                }

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private bool ActualizarModelo()
        {
            try
            {
                var resultado = _modeloService.ActualizarModelo(NuevoModelo);
                if (resultado.Type != TypeResponse.Ok)
                {
                    Notificaciones.MensajeError(resultado.Message);
                    return false;
                }

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private bool DesactivarTipoCeldaModelo(int tipoCeldaModeloId)
        {
            try
            {
                var resultado = _celdaService.DesactivarTipoCeldaModelo(tipoCeldaModeloId);
                if (resultado.Type != TypeResponse.Ok)
                {
                    Notificaciones.MensajeError(resultado.Message);
                    return false;
                }

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void PrepararNuevaModelo()
        {
            NuevoModelo.Descripcion = txtDescripcion.Text;
        }

        private bool EsValidaLaInformacionIngresadaParaNuevoModelo(out string mensaje)
        {
            if (string.IsNullOrEmpty(NuevoModelo.Descripcion))
            {
                mensaje = "Es necesario ingresar una descripción para el Modelo.";
                return false;
            }

            mensaje = "Ok";
            return true;
        }

        private void btnGuardarModelo_Click(object sender, EventArgs e)
        {
            PrepararNuevaModelo();

            if (!EsValidaLaInformacionIngresadaParaNuevoModelo(out string mensaje))
            {
                MessageBox.Show(mensaje);
                return;
            }

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));

            if (TipoTransaccion == TipoTransaccion.Insertar && GuardarModelo())
            {
                Notificaciones.MensajeConfirmacion("¡El Modelo se ha registrado exitosamente!");
                OnModeloAgregada?.Invoke(NuevoModelo);
                this.Close();

                SplashScreenManager.CloseForm();
                return;
            }

            if (ActualizarModelo())
            {
                Notificaciones.MensajeConfirmacion("¡El Modelo se ha actualizado exitosamente!");
                OnModeloModificada?.Invoke(NuevoModelo);
                this.Close();
            }

            SplashScreenManager.CloseForm();
        }

        private void btnAgregarTipoCelda_Click(object sender, EventArgs e)
        {
            if (leTipoCelda.EditValue == null || string.IsNullOrEmpty(leTipoCelda.Text))
            {
                Notificaciones.MensajeAdvertencia("Es necesario que seleccione un Tipo de Celda para vincularlo al Modelo.");
                return;
            }

            var tipoCeldaSeleccionada = tiposDeCeldas.FirstOrDefault(x => x.Id == (int)leTipoCelda.EditValue);
            if (tipoCeldaSeleccionada == null)
            {
                Notificaciones.MensajeAdvertencia($"No fue posible encontrar un Tipo Celda en almacén de datos, que coincida con Tipo de Celda seleccionado: {leTipoCelda.EditValue}.");
                return;
            }

            if (NuevoModelo.TipoCeldaModelo.Any(x => x.TipoCeldaId == tipoCeldaSeleccionada.Id))
            {
                Notificaciones.MensajeAdvertencia($"El tipo de celda seleccionado ya está vinculado a este Modelo.");
                return;
            }

            NuevoModelo.TipoCeldaModelo.Add(new TipoCeldaModeloDto
            {
                TipoCeldaId = tipoCeldaSeleccionada.Id,
                TipoDeCelda = tipoCeldaSeleccionada
            });
            gcTiposDeCeldaModelo.DataSource = NuevoModelo.TipoCeldaModelo;
            gcTiposDeCeldaModelo.RefreshDataSource();

            SetearTotales();
        }


    }
}