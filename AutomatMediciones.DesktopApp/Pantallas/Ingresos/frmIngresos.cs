using AutomatMediciones.DesktopApp.Enums;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Ingresos.Dtos;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Ingresos
{
    public partial class frmIngresos : DevExpress.XtraEditors.XtraForm
    {
        ContactoDto contactoSeleccionado;
        EmpresaDto empresaSeleccionada;
        CorreoElectronicoDto correoSeleccionado;
        TipoTrabajoDto tipoTrabajoSeleccionado;

        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private readonly IngresoService _ingresoService;
        private readonly InstrumentoService _instrumentoService;
        private readonly TipoTrabajoService _tipoTrabajoService;

        ICollection<IngresoInstrumentoDto> instrumentosSeleccionados;

        List<InstrumentoLista> instrumentosDeEmpresa;

        public IngresoDto Ingreso { get; set; }

        public frmIngresos(IngresoService ingresoService, InstrumentoService instrumentoService, TipoTrabajoService tipoTrabajoService)
        {
           
            InitializeComponent();

     
            Cursor.Current = Cursors.WaitCursor;

            _ingresoService = ingresoService;
            _instrumentoService = instrumentoService;
            _tipoTrabajoService = tipoTrabajoService;

           
            EstablecerNombreYTituloDePantalla();
            EstablecerColorBotonPorDefecto();
            EstablecerColorBotonGuardar();
            CargarDatosTiposDeTrabajo();

       
            Cursor.Current = Cursors.Arrow;

            Ingreso = new IngresoDto();
            instrumentosSeleccionados = new List<IngresoInstrumentoDto>();
            instrumentosDeEmpresa = new List<InstrumentoLista>();

            chkSeleccionarInstrumento.EditValueChanged += onSeleccionaInstrumento;

            btnEditarComentario.Click += clickEditarComentario;

        }

        private void clickEditarComentario(object sender, EventArgs e)
        {

            var instrumento = gvInstrumentosDeEmpresa.GetFocusedRow() as InstrumentoLista;
            if (instrumento == null) return;

            frmComentarioInstrumento frmComentarioInstrumento = new frmComentarioInstrumento();
            frmComentarioInstrumento.TipoTransaccion = TipoTransaccion.Actualizar;
            frmComentarioInstrumento.OnComentarioActualizado += OnComentarioActualizado;         
            frmComentarioInstrumento.Instrumento = instrumento;
            frmComentarioInstrumento.SetearComentarioParaActualizar(instrumento.Comentarios);
            frmComentarioInstrumento.Show();
        }

        private void onSeleccionaInstrumento(object sender, EventArgs e)
        {
            var checkSeleccionado = sender as DevExpress.XtraEditors.CheckEdit;
            if (checkSeleccionado.EditValue == null) return;

            var estaSeleccionadoElInstrumento = (bool)checkSeleccionado.EditValue;

            var instrumento = gvInstrumentosDeEmpresa.GetFocusedRow() as InstrumentoLista;   
            if (instrumento == null) return;

            instrumento.Seleccionado = estaSeleccionadoElInstrumento;

            if (instrumento.Seleccionado)
            {

                frmComentarioInstrumento frmComentarioInstrumento = new frmComentarioInstrumento();
                frmComentarioInstrumento.TipoTransaccion = TipoTransaccion.Insertar;
                frmComentarioInstrumento.OnComentarioAgregado += OnComentarioAgregado;
                frmComentarioInstrumento.Instrumento = instrumento;
                frmComentarioInstrumento.Show();
            }
            else
            {
                AccionPorRealizarDespuesDeSeleccion(instrumento);
            }
        }

        private void OnComentarioActualizado(InstrumentoLista instrumento)
        {
            ActualizarSeleccionDeInstrumento(instrumento);
        }

        private void AccionPorRealizarDespuesDeSeleccion(InstrumentoLista instrumento)
        {

            var yaFueSeleccionado = YaFueSeleccionadoElInstrumento(instrumento.InstrumentoId);
            if (!instrumento.Seleccionado && yaFueSeleccionado) QuitarInstrumentoDeListaDeSeleccionados(instrumento.InstrumentoId);

            if (instrumento.Seleccionado && !yaFueSeleccionado) AgregarInstrumentoEnListaDeSeleccionados(instrumento);

            lblInstrumentosSeleccionados.Text = $"Instrumentos Seleccionados: {instrumentosSeleccionados.Count}";
        }

        private void OnComentarioAgregado(InstrumentoLista instrumento)
        {
            AccionPorRealizarDespuesDeSeleccion(instrumento);
        }

        private void AgregarInstrumentoEnListaDeSeleccionados(InstrumentoLista instrumento)
        {
            var ingresoInstrumento = new IngresoInstrumentoDto
            {
                Comentarios = instrumento.Comentarios,
                InstrumentoId = instrumento.InstrumentoId,
                Activo = true
            };

            instrumentosSeleccionados.Add(ingresoInstrumento);

            ActualizarSeleccionDeInstrumento(instrumentosDeEmpresa.FirstOrDefault(x=> x.InstrumentoId == instrumento.InstrumentoId));
        }

        private void QuitarInstrumentoDeListaDeSeleccionados(int instrumentoId)
        {
            instrumentosSeleccionados = instrumentosSeleccionados.Where(x => x.InstrumentoId != instrumentoId).ToList();
            ActualizarSeleccionDeInstrumento(instrumentosDeEmpresa.FirstOrDefault(x => x.InstrumentoId == instrumentoId));
        }

        private bool YaFueSeleccionadoElInstrumento(int instrumentoId)
        {
            var instrumentosIds = instrumentosSeleccionados.Select(x => x.InstrumentoId);
            if (instrumentosIds.Contains(instrumentoId))
            {
                return true;
            }

            return false;
        }

        private void CargarDatosTiposDeTrabajo()
        {
            var resultado = _tipoTrabajoService.ObtenerTiposDeTrabajo();
     
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            glTiposTrabajo.Properties.DataSource = resultado.Data;
            glTiposTrabajo.Properties.DisplayMember = "Descripcion";
            glTiposTrabajo.Properties.ValueMember = "TipoTrabajoId";
        }

        private List<InstrumentoDto> ObtenerInstrumentosParaEmpresaSeleccionada()
        {
            var resultado = _instrumentoService.ObtenerInstrumentos(empresaSeleccionada.NombreEmpresa);
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            return resultado.Data;
        }

        private void ActualizarSeleccionDeInstrumento(InstrumentoLista instrumentoLista)
        {
            instrumentosDeEmpresa.FirstOrDefault(x => x.InstrumentoId == instrumentoLista.InstrumentoId).Seleccionado = instrumentoLista.Seleccionado;
            instrumentosDeEmpresa.FirstOrDefault(x => x.InstrumentoId == instrumentoLista.InstrumentoId).Comentarios = instrumentoLista.Comentarios;

            gcInstrumentosDeEmpresa.DataSource = instrumentosDeEmpresa;
            gcInstrumentosDeEmpresa.RefreshDataSource();
        }

        private void EstablecerSeleccionDeInstrumentos(List<InstrumentoDto> instrumentos)
        {
            instrumentosDeEmpresa = new List<InstrumentoLista>();

            instrumentos.ForEach(x =>
            {
                InstrumentoLista instrumentoLista = new InstrumentoLista
                {
                    Clasificacion = x.Clasificacion,
                    ClasificacionId = x.ClasificacionId,
                    Descripcion = x.Descripcion,
                    EmpresaId = x.EmpresaId,
                    FechaCompraCliente = x.FechaCompraCliente,
                    FechaCompraFabricante = x.FechaCompraFabricante,
                    FechaProximaCalibracion = x.FechaProximaCalibracion,
                    FechaUltimaCalibracion = x.FechaUltimaCalibracion,
                    Garantia = x.Garantia,
                    InstrumentoId = x.InstrumentoId,
                    NombreEmpresa = x.NombreEmpresa,
                    NumeroSerie = x.NumeroSerie,
                    PeriodoCalibracion = x.PeriodoCalibracion,
                    Seleccionado = false
                };

                instrumentosDeEmpresa.Add(instrumentoLista);
            });

            gcInstrumentosDeEmpresa.DataSource = instrumentosDeEmpresa;
        }

        private void EstablecerColorBotonPorDefecto()
        {
            btnAgregarNuevInstrumento.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnAgregarNuevInstrumento.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnAgregarNuevInstrumento.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void EstablecerColorBotonGuardar()
        {
            btnGuardarIngreso.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarIngreso.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarIngreso.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void EstablecerNombreYTituloDePantalla()
        {
            string titulo = "Ingresos";
            this.Text = titulo;
            this.ctlEncabezadoPantalla1.lblTitulo.Text = "Creación de Ingreso";
            this.ctlEncabezadoPantalla1.EstablecerColoresDeFondoYLetra();
        }

        private void iconButton1_MouseHover(object sender, System.EventArgs e)
        {
            toolTip1.SetToolTip(btnBuscarEmpresa, "Presione para ir la a pantalla que le permite buscar y seleccionar una empresa");
        }

        private void btnBuscarEmpresa_Click(object sender, System.EventArgs e)
        {
            var frmEmpresas = new frmEmpresas(serviceProvider.GetService<EmpresaService>());
            frmEmpresas.OnSeleccionaEmpresa += OnEmpresaSeleccionada;
            frmEmpresas.Show();
        }

        private void OnEmpresaSeleccionada(EmpresaDto empresa)
        {
            if (empresa == null) return;

            empresaSeleccionada = empresa;
            txtEmpresa.Text = empresaSeleccionada.NombreEmpresa;
            var instrumentos = ObtenerInstrumentosParaEmpresaSeleccionada();

            AsignarInstrumentosDeEmpresa(instrumentos);
            ObtenerContactosDeEmpresaSeleccionada();
        }

        private void AsignarInstrumentosDeEmpresa(List<InstrumentoDto> instrumentos)
        {
            EstablecerSeleccionDeInstrumentos(instrumentos);

            gcInstrumentosDeEmpresa.DataSource = null;
            gcInstrumentosDeEmpresa.DataSource = instrumentosDeEmpresa;
            lblTotalInstrumentos.Visible = true;
            lblInstrumentosSeleccionados.Visible = true;
            lblTotalInstrumentos.Text = $"Total Instrumentos: {instrumentos.Count}";
            lblInstrumentosSeleccionados.Text = $"Instrumentos Seleccionados: {instrumentosSeleccionados.Count}";
        }

        private void ObtenerContactosDeEmpresaSeleccionada()
        {
            LimpiarContactos();
            if (empresaSeleccionada == null) return;
            glContacto.Properties.DataSource = empresaSeleccionada.Contactos;
            glContacto.Properties.DisplayMember = "Nombre";
            glContacto.Properties.ValueMember = "ContactoId";
        }

        public void ObtenerCorreoElectronicoDeContacto()
        {

            LimpiarCorreos();

            if (contactoSeleccionado == null) return;
            glCorreoElectronico.Properties.DataSource = contactoSeleccionado.CorreosElectronicos;
            glCorreoElectronico.Properties.DisplayMember = "Direccion";
            glCorreoElectronico.Properties.ValueMember = "RegistroId";
        }

        private void glContacto_Properties_EditValueChanged(object sender, EventArgs e)
        {
            contactoSeleccionado = glContactos.GetFocusedRow() as ContactoDto;
            ObtenerCorreoElectronicoDeContacto();
        }

        private void LimpiarContactos()
        {
            glContacto.Properties.DataSource = null;
            contactoSeleccionado = null;
            LimpiarCorreos();
        }

        private void LimpiarCorreos()
        {
            glCorreoElectronico.Properties.DataSource = null;
        }

        private void btnAgregarNuevInstrumento_Click(object sender, EventArgs e)
        {
            frmNuevoInstrumento frmNuevoInstrumento = new frmNuevoInstrumento(serviceProvider.GetService<ClasificacionInstrumentoService>(), 
                                                                              serviceProvider.GetService<InstrumentoService>(),
                                                                              serviceProvider.GetService<MarcaService>(),
                                                                              serviceProvider.GetService<ModeloService>(),
                                                                              serviceProvider.GetService<TipoDeInstrumentoService>());
            frmNuevoInstrumento.OnEmpresaSeleccionada(empresaSeleccionada);
            frmNuevoInstrumento.OnInstrumentoAgregado += OnInstrumentoAgregado;
            frmNuevoInstrumento.Show();
        }

        private void OnInstrumentoAgregado(InstrumentoDto instrumento)
        {
            if (empresaSeleccionada != null)
            {
                InstrumentoLista instrumentoLista = new InstrumentoLista
                {
                    ClasificacionId = instrumento.ClasificacionId,
                    Clasificacion = instrumento.Clasificacion,
                    Descripcion = instrumento.Descripcion,
                    EmpresaId = instrumento.EmpresaId,
                    FechaCompraCliente = instrumento.FechaCompraCliente,
                    FechaCompraFabricante = instrumento.FechaCompraFabricante,
                    InstrumentoId = instrumento.InstrumentoId,
                    NumeroSerie = instrumento.NumeroSerie,
                    FechaProximaCalibracion = instrumento.FechaProximaCalibracion,
                    FechaUltimaCalibracion = instrumento.FechaUltimaCalibracion,
                    Garantia = instrumento.Garantia,
                    NombreEmpresa = instrumento.NombreEmpresa,
                    PeriodoCalibracion = instrumento.PeriodoCalibracion,
                    Seleccionado = false
                };


                instrumentosDeEmpresa.Add(instrumentoLista);
                gcInstrumentosDeEmpresa.DataSource = instrumentosDeEmpresa;
                gcInstrumentosDeEmpresa.RefreshDataSource();

                //ObtenerInstrumentosParaEmpresaSeleccionada();
            }
        }

        private void PrepararNuevoIngreso()
        {
            Ingreso.EmpresaId = empresaSeleccionada.EmpresaId;
            Ingreso.NombreEmpresa = empresaSeleccionada.NombreEmpresa;
            Ingreso.ContactoId = contactoSeleccionado.ContactoId;
            Ingreso.NombreContacto = contactoSeleccionado.Nombre;
            Ingreso.CorreoElectronicoId = correoSeleccionado.RegistroId;
            Ingreso.DireccionCorreoElectronico = correoSeleccionado.Direccion;
            Ingreso.IngresosInstrumentos = instrumentosSeleccionados;
            Ingreso.EstadoId = (int)Estados.Ingresado;
            Ingreso.TipoTrabajoId = tipoTrabajoSeleccionado.TipoTrabajoId;
            Ingreso.CuerpoCorreo = memoComentarios.Text;
            Ingreso.Prioridad = trackBarControl1.Value;
        }

        private void glCorreoElectronico_EditValueChanged(object sender, EventArgs e)
        {
            correoSeleccionado = glCorreo.GetFocusedRow() as CorreoElectronicoDto;
        }

        private bool SeLlenaronCamposObligatorios(out string mensaje)
        {

            if (empresaSeleccionada == null)
            {
                mensaje = "Es necesario que seleccione una empresa para continuar";
                return false;
            }

            if (contactoSeleccionado == null)
            {
                mensaje = "Es necesario que seleccione un contacto para continuar";
                return false;
            }

            if (correoSeleccionado == null)
            {
                mensaje = "Es necesario que seleccione un correo para continuar";
                return false;
            }

            if (!instrumentosSeleccionados.Any())
            {
                mensaje = "Es necesario que seleccione al menos un instrumento para continuar";
                return false;
            }

            if (tipoTrabajoSeleccionado == null)
            {
                mensaje = "Es necesario que seleccione un tipo de trabajo para continuar";
                return false;
            }

            mensaje = "Ok";
            return true;
        }

        private void btnGuardarIngreso_Click(object sender, EventArgs e)
        {
            if (!SeLlenaronCamposObligatorios(out string mensaje))
            {
                Notificaciones.MensajeAdvertencia(mensaje);
                return;
            }

            PrepararNuevoIngreso();

            SplashScreenManager.ShowForm(typeof(frmLoading));
            if (GuardarIngreso())
            {
                Notificaciones.MensajeConfirmacion("¡El ingreso se ha guardado exitosamente!");
                LimpiarFormulario();
            }
            SplashScreenManager.CloseForm();
        }

        private bool GuardarIngreso()
        {
            try
            {
                var resultado = _ingresoService.GuardarIngreso(Ingreso);
                if (resultado.Type != TypeResponse.Ok)
                {
                    Notificaciones.MensajeError(resultado.Message);                   
                    return false;
                }

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(Exceptions.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void glTiposTrabajo_EditValueChanged(object sender, EventArgs e)
        {
            tipoTrabajoSeleccionado = glTipoTrabajo.GetFocusedRow() as TipoTrabajoDto;
        }

        private void LimpiarFormulario()
        {
            txtEmpresa.ResetText();
            glContacto.EditValue = null;
            glCorreoElectronico.EditValue = null;
            instrumentosSeleccionados.Clear();
            gcInstrumentosDeEmpresa.DataSource = null;
            lblInstrumentosSeleccionados.Text = "";
            lblTotalInstrumentos.Text = "";
            lblTotalInstrumentos.Visible = false;
            lblInstrumentosSeleccionados.Visible = false;
            glTiposTrabajo.EditValue = null;
            memoComentarios.Text = "";
            trackBarControl1.Value = 1;
            empresaSeleccionada = null;
            tipoTrabajoSeleccionado = null;
            contactoSeleccionado = null;
            correoSeleccionado = null;
            Ingreso = new IngresoDto();
        }

        private void btnAgregarNuevInstrumento_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAgregarNuevInstrumento_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAgregarNuevInstrumento, "Presione para ir la a pantalla que le permite agregar un nuevo instrumento.");
        }
    }
}

