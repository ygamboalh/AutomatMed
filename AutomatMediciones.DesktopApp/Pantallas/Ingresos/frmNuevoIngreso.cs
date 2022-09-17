using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Enums;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Ingresos.Dtos;
using AutomatMediciones.DesktopApp.Pantallas.Ingresos.Enums;
using AutomatMediciones.DesktopApp.Pantallas.Instrumentos;
using AutomatMediciones.DesktopApp.Reportes;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Ingresos
{
    public partial class frmNuevoIngreso : DevExpress.XtraEditors.XtraForm
    {
        private ServiceProvider serviceProvider = Program.services.BuildServiceProvider();

        ContactoDto contactoSeleccionado;
        EmpresaDto empresaSeleccionada;
        UsuarioDto usuarioSeleccionado;
        EstadoDto estadoSeleccionado;

        private readonly IngresoService _ingresoService;
        private readonly InstrumentoService _instrumentoService;
        private readonly UsuarioService _usuarioService;
        private readonly ConfiguracionNotificacionService _configuracionNotificacionService;
        private readonly EstadoService _estadoService;
        private readonly EmpresaService _empresaService;
        private readonly string _textoEmail;

        ICollection<InstrumentoLista> instrumentosListaSeleccionados;
        ICollection<IngresoInstrumentoDto> instrumentosSeleccionados;
        List<UsuarioDto> copiasEnCorreo;
        List<InstrumentoLista> instrumentosDeEmpresa;
        ConfiguracionNotificacionDto configuracionNotificacion;
        List<EstadoDto> estados = new List<EstadoDto>();
        List<UsuarioDto> usuarios = new List<UsuarioDto>();

        public delegate void IngresoActualizado(IngresoDto ingreso);
        public event IngresoActualizado OnIngresoActualizado;

        public TipoTransaccion TipoTransaccion { get; set; }
        public TiposIngreso TipoIngreso { get; set; }
        public IngresoDto Ingreso { get; set; }

        public frmNuevoIngreso(TiposIngreso tipoIngreso, TipoTransaccion tipoTransaccion, IngresoService ingresoService, InstrumentoService instrumentoService,
            UsuarioService usuarioService, ConfiguracionNotificacionService configuracionNotificacionService, EstadoService estadoService, EmpresaService empresaService)
        {
            InitializeComponent();

            Cursor.Current = Cursors.WaitCursor;

            TipoTransaccion = tipoTransaccion;
            TipoIngreso = tipoIngreso;

            _ingresoService = ingresoService;
            _instrumentoService = instrumentoService;
            _usuarioService = usuarioService;
            _configuracionNotificacionService = configuracionNotificacionService;
            _estadoService = estadoService;
            _empresaService = empresaService;
            _textoEmail = memoEmail.Text;

            btnGuardarIngreso.Text = $"Guardar {ObtenerDescripcionTipoIngreso()}";

            EstablecerNombreYTituloDePantalla();
            EstablecerColorBotonPorDefecto();
            EstablecerColorBotonGuardar();

            dateFechaIngreso.Value = DateTime.Now;
            copiasEnCorreo = new List<UsuarioDto>();
            CargarUsuarios();
            CargarConfiguraciones();
            CargarEstados();

            Cursor.Current = Cursors.Arrow;
            Ingreso = new IngresoDto();

            instrumentosListaSeleccionados = new List<InstrumentoLista>();
            instrumentosSeleccionados = new List<IngresoInstrumentoDto>();
            instrumentosDeEmpresa = new List<InstrumentoLista>();

            btnAgregarAListaSeleccionados.Click += onSeleccionaInstrumento;
            btnEditarInstrumento.Click += clickEditarInstrumento;

            bntBorrarInstrumento.Click += clickBorrarInstrumento;
            btnEditarComentario.Click += clickEditarComentario;
        }

        private void clickBorrarInstrumento(object sender, EventArgs e)
        {
            var instrumento = gvInstrumentosSeleccionados.GetFocusedRow() as Dtos.InstrumentoLista;
            if (instrumento == null) return;

            if (instrumento.InstrumentoId != 0)
            {
                _ingresoService.QuitarInstrumentoDeListaIngreso(instrumento.InstrumentoId);
                instrumentosListaSeleccionados = instrumentosListaSeleccionados.Where(x => x.InstrumentoId != instrumento.InstrumentoId).ToList();
                gcInstrumentosSeleccionados.DataSource = instrumentosListaSeleccionados;
                gcInstrumentosSeleccionados.RefreshDataSource();

                return;
            }

            QuitarInstrumentoDeListaDeSeleccionados(instrumento.InstrumentoId);
        }

        private void clickEditarInstrumento(object sender, EventArgs e)
        {
            var instrumento = gvInstrumentosDeEmpresa.GetFocusedRow() as InstrumentoDto;
            if (instrumento == null) return;

            SplashScreenManager.ShowForm(typeof(frmSaving));

            serviceProvider = Program.services.BuildServiceProvider();
            var frmNuevoInstrumento = new frmNuevoInstrumento(TipoTransaccion.Actualizar, serviceProvider.GetService<ClasificacionInstrumentoService>(),
                                                                           serviceProvider.GetService<InstrumentoService>(),
                                                                           serviceProvider.GetService<MarcaService>(),
                                                                           serviceProvider.GetService<ModeloService>(),
                                                                           serviceProvider.GetService<TipoDeInstrumentoService>(),
                                                                           serviceProvider.GetService<EmpresaService>(),
                                                                            serviceProvider.GetService<CeldaService>());

            frmNuevoInstrumento.OnInstrumentoModificado += OnIntrumentoModificado;
            frmNuevoInstrumento.NuevoInstrumento = instrumento;
            frmNuevoInstrumento.CargarVariablesInstrumentos();
            frmNuevoInstrumento.SetearValoresParaActualizar();
            SplashScreenManager.CloseForm();
            frmNuevoInstrumento.ShowDialog();
        }

        public void SetearVariablesParaActualizar()
        {
            var resultEmpresa = _empresaService.ObtenerEmpresaPorId(Ingreso.EmpresaId);
            if (resultEmpresa.Type != TypeResponse.Ok)
            {
                Notificaciones.MensajeError(resultEmpresa.Message);
                return;
            }

            empresaSeleccionada = new EmpresaDto();
            empresaSeleccionada = resultEmpresa.Data;

            txtEmpresa.Text = empresaSeleccionada.NombreEmpresa;
            ObtenerContactosDeEmpresaSeleccionada();
            var instrumentos = ObtenerInstrumentosParaEmpresaSeleccionada();

            AsignarInstrumentosDeEmpresa(instrumentos);

            instrumentosListaSeleccionados = ObtenerInstrumentosListasSeleccionados();
            instrumentosSeleccionados = Ingreso.IngresosInstrumentos;


            var estadoId = Ingreso.IngresosInstrumentos.FirstOrDefault(y => y.IngresoId == Ingreso.IngresoId).EstadoId;

            glEstado.EditValue = estadoId;
            estadoSeleccionado = new EstadoDto();
            estadoSeleccionado = estados.FirstOrDefault(x => x.EstadoId == estadoId);

            var usuarioId = Ingreso.IngresosInstrumentos.FirstOrDefault(y => y.IngresoId == Ingreso.IngresoId).ResponsableId;
            glUsuariosResponsables.EditValue = usuarioId;
            usuarioSeleccionado = new UsuarioDto();
            usuarioSeleccionado = usuarios.FirstOrDefault(x => x.UsuarioId == usuarioId);

            glContacto.EditValue = Ingreso.ContactoId;
            memoCorreos.Text = Ingreso.DireccionCorreoElectronico;
            memoEmail.Text = Ingreso.CuerpoCorreo;
            glUsuariosResponsables.EditValue = Ingreso.UsuarioId;

            gcInstrumentosSeleccionados.DataSource = instrumentosListaSeleccionados;
            gcInstrumentosSeleccionados.RefreshDataSource();

            SetearTotales();

            checkEnviarReporte.Visible = false;

        }

        private List<InstrumentoLista> ObtenerInstrumentosListasSeleccionados()
        {
            List<InstrumentoLista> lista = new List<InstrumentoLista>();
            Ingreso.IngresosInstrumentos.ToList().ForEach(x =>
            {
                lista.Add(new InstrumentoLista
                {
                    InstrumentoId = x.InstrumentoId,
                    ClasificacionId = x.Instrumento.ClasificacionId,
                    Comentarios = x.Instrumento.Comentarios,
                    EmpresaId = x.Instrumento.EmpresaId,
                    NumeroSerie = x.Instrumento.NumeroSerie,
                    Descripcion = x.Instrumento.Descripcion,
                    FechaCompraCliente = x.Instrumento.FechaCompraCliente,
                    FechaCompraFabricante = x.Instrumento.FechaCompraFabricante,
                    Garantia = x.Instrumento.Garantia,
                    NombreEmpresa = x.Instrumento.NombreEmpresa,
                    FechaProximaCalibracion = x.Instrumento.FechaProximaCalibracion,
                    FechaUltimaCalibracion = x.Instrumento.FechaUltimaCalibracion,
                    PeriodoCalibracion = x.Instrumento.PeriodoCalibracion,
                    Clasificacion = x.Instrumento.Clasificacion,
                    InformacionAdicional = new InformacionAdicionalInstrumento
                    {
                        Comentarios = x.Comentarios,
                        TipoTrabajoId = x.TipoTrabajoId,
                        InstrumentoId = x.InstrumentoId,
                        FechaEntregaRequerida = x.FechaEntregaRequerida,
                        Prioridad = x.Prioridad,
                        TipoTrabajo = x.TipoTrabajo
                    },
                    ClasificacionConcatenada = $"{x.Instrumento.Clasificacion.TipoInstrumento.Descripcion}/{x.Instrumento.Clasificacion.Marca.Descripcion}/{x.Instrumento.Clasificacion.Modelo.Descripcion}",
                });
            });

            return lista;
        }

        private void OnIntrumentoModificado(InstrumentoDto instrumento)
        {
            instrumentosDeEmpresa = instrumentosDeEmpresa.Where(x => x.InstrumentoId != instrumento.InstrumentoId).ToList();

            instrumentosDeEmpresa.Add(new InstrumentoLista
            {
                InstrumentoId = instrumento.InstrumentoId,
                ClasificacionConcatenada = $"{instrumento.Clasificacion.TipoInstrumento.Descripcion}/{instrumento.Clasificacion.Marca.Descripcion}/{instrumento.Clasificacion.Modelo.Descripcion}",
                ClasificacionId = instrumento.ClasificacionId,
                Clasificacion = instrumento.Clasificacion,
                Comentarios = instrumento.Comentarios,
                Descripcion = instrumento.Descripcion,
                EmpresaId = instrumento.EmpresaId,
                FechaCompraCliente = instrumento.FechaCompraCliente,
                FechaCompraFabricante = instrumento.FechaCompraFabricante,
                FechaProximaCalibracion = instrumento.FechaProximaCalibracion,
                FechaUltimaCalibracion = instrumento.FechaUltimaCalibracion,
                Garantia = instrumento.Garantia,
                NombreEmpresa = instrumento.NombreEmpresa,
                NumeroSerie = instrumento.NumeroSerie,
                PeriodoCalibracion = instrumento.PeriodoCalibracion
            });

            gcInstrumentosDeEmpresa.RefreshDataSource();
        }

        private void CargarConfiguraciones()
        {
            var resultado = _configuracionNotificacionService.ObtenerConfiguraciones();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            configuracionNotificacion = resultado.Data;
        }

        private void CargarEstados()
        {
            var resultado = _estadoService.ObtenerEstados();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            estados = resultado.Data;

            glEstado.Properties.DataSource = estados;
            glEstado.Properties.DisplayMember = "Descripcion";
            glEstado.Properties.ValueMember = "EstadoId";
        }

        private void CargarUsuarios()
        {
            var resultado = _usuarioService.ObtenerUsuariosActivos();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            usuarios = resultado.Data;

            copiasEnCorreo = usuarios.Where(x => x.CopiaEnNotificaciones).ToList();

            glUsuariosResponsables.Properties.DataSource = usuarios;
            glUsuariosResponsables.Properties.DisplayMember = "Nombre";
            glUsuariosResponsables.Properties.ValueMember = "UsuarioId";
        }

        private void clickEditarComentario(object sender, EventArgs e)
        {
            var instrumento = gvInstrumentosSeleccionados.GetFocusedRow() as Dtos.InstrumentoLista;
            if (instrumento == null) return;

            var ingresoInstrumento = instrumentosSeleccionados.FirstOrDefault(x => x.InstrumentoId.Equals(instrumento.InstrumentoId));
            if (ingresoInstrumento == null) return;

            serviceProvider = Program.services.BuildServiceProvider();
            frmInformacionAdicionalInstrumento frmComentarioInstrumento = new frmInformacionAdicionalInstrumento(TipoTransaccion.Actualizar, serviceProvider.GetService<TipoTrabajoService>());
            frmComentarioInstrumento.OnInformacionAdicionalActualizada += OnInformacionAdicionalActualizada;
            frmComentarioInstrumento.SetearInformacionAdicionalParaActualizar(ingresoInstrumento, instrumento.Seleccionado, instrumento.InformacionAdicional.ComentariosAcercaInstrumento);
            frmComentarioInstrumento.ShowDialog();
        }

        private void OnInformacionAdicionalActualizada(InstrumentoLista instrumento)
        {
            instrumentosListaSeleccionados = instrumentosListaSeleccionados.Where(x => x.InstrumentoId != instrumento.InstrumentoId).ToList();
            instrumentosSeleccionados = instrumentosSeleccionados.Where(x => x.InstrumentoId != instrumento.InstrumentoId).ToList();

            AgregarInstrumentoEnListaDeSeleccionados(instrumento);
        }

        private void onSeleccionaInstrumento(object sender, EventArgs e)
        {
            var instrumento = gvInstrumentosDeEmpresa.GetFocusedRow() as InstrumentoLista;
            if (instrumento == null) return;

            serviceProvider = Program.services.BuildServiceProvider();
            frmInformacionAdicionalInstrumento frmComentarioInstrumento = new frmInformacionAdicionalInstrumento(TipoTransaccion.Insertar, serviceProvider.GetService<TipoTrabajoService>());
            frmComentarioInstrumento.OnInformacionAdicionalAgregada += OnInformacionAgregada;
            frmComentarioInstrumento.Instrumento = instrumento;
            frmComentarioInstrumento.memoComentariosAcercaInstrumento.Text = instrumento.Comentarios;
            frmComentarioInstrumento.Instrumento.InformacionAdicional = new InformacionAdicionalInstrumento();
            frmComentarioInstrumento.ShowDialog();
        }

        private void OnInformacionAgregada(InstrumentoLista instrumento)
        {
            AgregarInstrumentoEnListaDeSeleccionados(instrumento);
        }

        private void AgregarInstrumentoEnListaDeSeleccionados(InstrumentoLista instrumento)
        {
            var ingresoInstrumento = new IngresoInstrumentoDto
            {
                Comentarios = instrumento.InformacionAdicional.Comentarios,
                Prioridad = instrumento.InformacionAdicional.Prioridad,
                TipoTrabajoId = instrumento.InformacionAdicional.TipoTrabajoId,
                FechaEntregaRequerida = instrumento.InformacionAdicional.FechaEntregaRequerida.Value,
                InstrumentoId = instrumento.InstrumentoId,
                Activo = true,
                Instrumento = instrumento
            };


            instrumentosSeleccionados.Add(ingresoInstrumento);
            ActualizarSeleccionDeInstrumento(instrumentosDeEmpresa.FirstOrDefault(x => x.InstrumentoId == instrumento.InstrumentoId));
            SetearTotales();
        }

        private void QuitarInstrumentoDeListaDeSeleccionados(int instrumentoId)
        {
            instrumentosSeleccionados = instrumentosSeleccionados.Where(x => x.InstrumentoId != instrumentoId).ToList();
            instrumentosListaSeleccionados = instrumentosListaSeleccionados.Where(x => x.InstrumentoId != instrumentoId).ToList();

            gcInstrumentosSeleccionados.DataSource = instrumentosListaSeleccionados;
            gcInstrumentosSeleccionados.RefreshDataSource();
            SetearTotales();
        }

        private List<InstrumentoDto> ObtenerInstrumentosParaEmpresaSeleccionada()
        {
            var resultado = _instrumentoService.ObtenerInstrumentos(empresaSeleccionada.NombreEmpresa);
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            return resultado.Data;
        }

        private void ActualizarSeleccionDeInstrumento(InstrumentoLista instrumentoLista)
        {
            var instrumento = instrumentosDeEmpresa.FirstOrDefault(x => x.InstrumentoId == instrumentoLista.InstrumentoId);
            instrumento.ClasificacionConcatenada = $"{instrumentoLista.Clasificacion.TipoInstrumento.Descripcion}/{instrumentoLista.Clasificacion.Marca.Descripcion}/{instrumentoLista.Clasificacion.Modelo.Descripcion}";

            instrumentosListaSeleccionados.Add(instrumento);
            gcInstrumentosSeleccionados.DataSource = instrumentosListaSeleccionados;
            gcInstrumentosSeleccionados.RefreshDataSource();

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
                    Comentarios = x.Comentarios,
                    NumeroSerie = x.NumeroSerie,
                    PeriodoCalibracion = x.PeriodoCalibracion,
                    Seleccionado = false,
                    ClasificacionConcatenada = $"{x.Clasificacion.TipoInstrumento.Descripcion} / {x.Clasificacion.Marca.Descripcion} / {x.Clasificacion.Modelo.Descripcion}"
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
            string tipo = ObtenerDescripcionTipoIngreso();
            this.Text = tipo;

            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = TipoTransaccion == TipoTransaccion.Insertar ? $"Creación de {tipo}" : $"Modificar {tipo}";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }

        private void iconButton1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnBuscarEmpresa, "Presione para ir la a pantalla que le permite buscar y seleccionar una empresa");
        }

        private void btnBuscarEmpresa_Click(object sender, EventArgs e)
        {
            var frmEmpresas = new frmEmpresas(serviceProvider.GetService<EmpresaService>());
            frmEmpresas.OnSeleccionaEmpresa += OnEmpresaSeleccionada;
            frmEmpresas.ShowDialog();

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

            SetearTotales();
        }

        private void SetearTotales()
        {
            lblTotalInstrumentos.Visible = true;
            lblInstrumentosSeleccionados.Visible = true;
            lblTotalInstrumentos.Text = $"Total Instrumentos: {gvInstrumentosDeEmpresa.DataRowCount}";
            lblInstrumentosSeleccionados.Text = $"Instrumentos Seleccionados: {gvInstrumentosSeleccionados.DataRowCount}";
        }

        private string ObtenerAsuntoSegunTipoIngreso()
        {
            string asunto = TipoIngreso == TiposIngreso.IngresoGeneral ? "Notificación por recepción de Instrumentos" : "Notificación por Pre-Ingreso de Instrumentos";
            return asunto;
        }

        private void ObtenerContactosDeEmpresaSeleccionada()
        {
            LimpiarContactos();
            if (empresaSeleccionada == null) return;

            List<ContactoLista> contactoListas = new List<ContactoLista>();

            empresaSeleccionada.Contactos.ToList().ForEach(x =>
            {
                var contacto = new ContactoLista
                {
                    ContactoId = x.ContactoId,
                    Apellido = x.Apellido,
                    Cargo = x.Cargo,
                    ContactoConcatenado = $"{x.Nombre} {x.Apellido}",
                    EmpresaId = x.EmpresaId,
                    Nombre = x.Nombre,
                    CorreosElectronicos = x.CorreosElectronicos
                };

                contactoListas.Add(contacto);
            });

            glContacto.Properties.DataSource = contactoListas;

            glContacto.Properties.DisplayMember = "ContactoConcatenado";
            glContacto.Properties.ValueMember = "ContactoId";
        }

        public void ObtenerCorreoElectronicoDeContacto()
        {
            LimpiarCorreos();

            if (contactoSeleccionado == null) return;
            var correos = string.Join(",", contactoSeleccionado.CorreosElectronicos.Select(x => x.Direccion).ToList());

            memoCorreos.Text = correos;
        }

        private void BusquedaCorreo()
        {
            contactoSeleccionado = glContactos.GetFocusedRow() as ContactoDto;
            ObtenerCorreoElectronicoDeContacto();
        }

        private void glContacto_Properties_EditValueChanged(object sender, EventArgs e)
        {
            BusquedaCorreo();
        }

        private void LimpiarContactos()
        {
            glContacto.Properties.DataSource = null;
            contactoSeleccionado = null;
            LimpiarCorreos();
            memoEmail.Text = _textoEmail;
        }

        private void LimpiarCorreos()
        {
            memoCorreos.ResetText();
        }

        private void btnAgregarNuevInstrumento_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            serviceProvider = Program.services.BuildServiceProvider();
            frmNuevoInstrumento frmNuevoInstrumento = new frmNuevoInstrumento(TipoTransaccion.Insertar, serviceProvider.GetService<ClasificacionInstrumentoService>(),
                                                                              serviceProvider.GetService<InstrumentoService>(),
                                                                              serviceProvider.GetService<MarcaService>(),
                                                                              serviceProvider.GetService<ModeloService>(),
                                                                              serviceProvider.GetService<TipoDeInstrumentoService>(),
                                                                              serviceProvider.GetService<EmpresaService>(),
                                                                              serviceProvider.GetService<CeldaService>()
                                                                              );
            frmNuevoInstrumento.OnEmpresaSeleccionada(empresaSeleccionada);
            frmNuevoInstrumento.OnInstrumentoAgregado += OnInstrumentoAgregado;
            SplashScreenManager.CloseForm();
            frmNuevoInstrumento.ShowDialog();

        }

        private void OnInstrumentoAgregado(InstrumentoDto instrumento)
        {
            serviceProvider = Program.services.BuildServiceProvider();

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
                    Seleccionado = false,
                    Comentarios = instrumento.Comentarios,
                    ClasificacionConcatenada = $"{instrumento.Clasificacion.TipoInstrumento.Descripcion}/{instrumento.Clasificacion.Marca.Descripcion}/{instrumento.Clasificacion.Modelo.Descripcion}"
                };


                instrumentosDeEmpresa.Add(instrumentoLista);
                gcInstrumentosDeEmpresa.DataSource = instrumentosDeEmpresa;
                gcInstrumentosDeEmpresa.RefreshDataSource();
            }
        }

        private void PrepararNuevoIngreso()
        {
            Ingreso.EmpresaId = empresaSeleccionada.EmpresaId;
            Ingreso.NombreEmpresa = empresaSeleccionada.NombreEmpresa;
            Ingreso.ContactoId = contactoSeleccionado.ContactoId;
            Ingreso.NombreContacto = contactoSeleccionado.Nombre;
            Ingreso.ApellidoContacto = contactoSeleccionado.Apellido;
            Ingreso.CorreoElectronicoId = "";
            Ingreso.DireccionCorreoElectronico = memoCorreos.Text;
            Ingreso.IngresosInstrumentos = instrumentosSeleccionados;
            Ingreso.CuerpoCorreo = memoEmail.Text;
            Ingreso.UsuarioId = usuarioSeleccionado.UsuarioId;
            Ingreso.FechaRegistro = dateFechaIngreso.Value;
            Ingreso.TipoIngresoId = (int)TipoIngreso;

            Ingreso.IngresosInstrumentos.ToList().ForEach(x =>
            {
                x.EstadoId = (int)glEstado.EditValue;
            });
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

            if (string.IsNullOrEmpty(memoCorreos.Text))
            {
                mensaje = "Es necesario que ingrese una dirección de correo para continuar";
                return false;
            }

            if (!instrumentosSeleccionados.Any())
            {
                mensaje = "Es necesario que seleccione al menos un instrumento para continuar";
                return false;
            }

            if (estadoSeleccionado == null)
            {
                mensaje = "Es necesario que seleccione un estado inicial para guardar el ingreso.";
                return false;
            }

            if (usuarioSeleccionado == null)
            {
                mensaje = "Es necesario que seleccione la persona responsable del ingreso.";
                return false;
            }

            mensaje = "Ok";
            return true;
        }

        public string ConvertirTextoPlanoEmailHaciaHtml()
        {
            StringBuilder textoEmail = new StringBuilder();
            bool yaInicioLasLineasDeFirmaParaElEmail = false;

            textoEmail.AppendLine();
            textoEmail.AppendLine($"<p style style={"line-height: 100%"}>");
            foreach (var line in memoEmail.Lines)
            {
                if (line.Contains("Saludos Cordiales"))
                {
                    yaInicioLasLineasDeFirmaParaElEmail = true;
                }

                if (line.Contains("Automat Medición S.R.L.") || line.Contains("Whatsapp"))
                {
                    string pararrafo = $"<strong> {line.Replace(Environment.NewLine, "<br />\r\n")} </strong><br>";

                    pararrafo = Regex.Replace(pararrafo, @"\[\[(.+)\]\[(.+)\]\]", "<a href=\"$2\">$1</a>");
                    pararrafo = Regex.Replace(pararrafo, @"\[\[(.+)\]\]", "<a href=\"$1\">$1</a>");
                    textoEmail.AppendLine(pararrafo);

                }
                else if (string.IsNullOrEmpty(line))
                {
                    textoEmail.AppendLine("<br>");
                }
                else
                {
                    if (yaInicioLasLineasDeFirmaParaElEmail)
                    {
                        string parrafo = line.Replace(Environment.NewLine, "<br />\r\n");

                        parrafo = Regex.Replace(parrafo, @"\[\[(.+)\]\[(.+)\]\]", "<a href=\"$2\">$1</a>");
                        parrafo = Regex.Replace(parrafo, @"\[\[(.+)\]\]", "<a href=\"$1\">$1</a>");
                        textoEmail.AppendLine($"{parrafo}<br>");
                    }
                    else
                    {
                        string parrafo = line.Replace(Environment.NewLine, "<br />\r\n");

                        parrafo = Regex.Replace(parrafo, @"\[\[(.+)\]\[(.+)\]\]", "<a href=\"$2\">$1</a>");
                        parrafo = Regex.Replace(parrafo, @"\[\[(.+)\]\]", "<a href=\"$1\">$1</a>");

                        if (line.Contains("."))
                        {
                            parrafo = $"{parrafo} <br>";
                        }
                        textoEmail.AppendLine(parrafo);
                    }
                }
            }

            textoEmail.AppendLine("</p>");

            return textoEmail.ToString();
        }

        private void btnGuardarIngreso_Click(object sender, EventArgs e)
        {
            string descripcionIngreso = ObtenerDescripcionTipoIngreso();
            if (!SeLlenaronCamposObligatorios(out string mensaje))
            {
                Notificaciones.MensajeAdvertencia(mensaje);
                return;
            }

            PrepararNuevoIngreso();

            if (TipoTransaccion == TipoTransaccion.Insertar)
            {
                SplashScreenManager.ShowForm(typeof(frmLoadingSave));
                if (GuardarIngreso())
                {
                    if (checkEnviarReporte.CheckState == CheckState.Checked)
                    {
                        var correoHelper = new CorreoHelper();
                        if (correoHelper.EnviarCorreo(PrepararCorreo()))
                        {
                            Notificaciones.MensajeConfirmacion($"¡El {descripcionIngreso} se ha guardado exitosamente!");
                        }
                        else
                        {
                            Notificaciones.MensajeConfirmacion($"El {descripcionIngreso} se ha guardado exitosamente, pero hubo una falla en el momento de enviar la notificación por correo electrónico.");
                        }

                        if (Notificaciones.PreguntaConfirmacion($"¿Desea imprimir Reporte de {descripcionIngreso}?") == DialogResult.Yes)
                        {
                            rptIngreso reporteIngreso = new rptIngreso();
                            reporteIngreso.objectDataSource1.DataSource = Ingreso;
                            reporteIngreso.DisplayName = $"{descripcionIngreso} #{Ingreso.IngresoId}.pdf";
                            ReportPrintTool printTool = new ReportPrintTool(reporteIngreso);
                            printTool.ShowRibbonPreview();
                        }
                    }
                    else
                    {
                        Notificaciones.MensajeConfirmacion($"¡El {descripcionIngreso} se ha guardado exitosamente!");

                        if (Notificaciones.PreguntaConfirmacion($"¿Desea imprimir reporte de {descripcionIngreso}?") == DialogResult.Yes)
                        {
                            rptIngreso reporteIngreso = new rptIngreso();
                            reporteIngreso.objectDataSource1.DataSource = Ingreso;
                            reporteIngreso.DisplayName = $"{descripcionIngreso} #{Ingreso.IngresoId}.pdf";
                            ReportPrintTool printTool = new ReportPrintTool(reporteIngreso);
                            printTool.ShowRibbonPreview();
                        }
                    }

                    LimpiarFormulario();
                }

                SplashScreenManager.CloseForm();
                return;
            }

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));
            if (ActualizarIngreso())
            {
                Notificaciones.MensajeConfirmacion($"¡El {descripcionIngreso} se actualizó exitosamente!");
                LimpiarFormulario();

            }


            SplashScreenManager.CloseForm();
            this.Close();
            OnIngresoActualizado?.Invoke(Ingreso);
        }

        private string ObtenerDescripcionTipoIngreso()
        {
            return TipoIngreso == TiposIngreso.IngresoGeneral ? "Ingreso" : "Pre-Ingreso";
        }

        private CorreoNotificacionDto PrepararCorreo()
        {
            List<string> copias = new List<string>();
            string descripcionTipoIngreso = ObtenerDescripcionTipoIngreso();

            copiasEnCorreo.ForEach(x =>
            {
                copias.Add(x.Correo);
            });

            rptIngreso reporteIngreso = new rptIngreso();
            reporteIngreso.objectDataSource1.DataSource = Ingreso;
            reporteIngreso.DisplayName = $"{descripcionTipoIngreso} #{Ingreso.IngresoId}.pdf";

            MemoryStream reportStream = new MemoryStream();
            reporteIngreso.ExportToPdf(reportStream);

            var diccionarioAdjuntos = new Dictionary<string, Stream>();
            diccionarioAdjuntos.Add(reporteIngreso.DisplayName, reportStream);

            string textoEmail = ConvertirTextoPlanoEmailHaciaHtml();

            configuracionNotificacion.Asunto = ObtenerAsuntoSegunTipoIngreso();
            configuracionNotificacion.Asunto = $"{configuracionNotificacion.Asunto} | {descripcionTipoIngreso} #{Ingreso.IngresoId}";

            CorreoNotificacionDto correoNotificacionDto = new CorreoNotificacionDto
            {
                Body = textoEmail,
                NombreEmpresa = empresaSeleccionada.NombreEmpresa,
                NombreDestinatario = contactoSeleccionado.Nombre,
                CorreoDestinatario = memoCorreos.Text,
                CopiasEnCorreo = copias,
                Configuracion = configuracionNotificacion,
                IngresoId = Ingreso.IngresoId,
                Adjuntos = diccionarioAdjuntos,
                AdjuntoMediaType = "application/pdf"
            };

            return correoNotificacionDto;
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

                Ingreso = resultado.Data;
                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private bool ActualizarIngreso()
        {
            try
            {
                var resultado = _ingresoService.ActualizarIngreso(Ingreso);
                if (resultado.Type != TypeResponse.Ok)
                {
                    Notificaciones.MensajeError(resultado.Message);
                    return false;
                }

                Ingreso = resultado.Data;
                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void LimpiarFormulario()
        {
            txtEmpresa.ResetText();
            memoCorreos.ResetText();
            glContacto.EditValue = null;
            glUsuariosResponsables.EditValue = null;
            glEstado.EditValue = null;
            instrumentosSeleccionados.Clear();
            gcInstrumentosDeEmpresa.DataSource = null;
            lblInstrumentosSeleccionados.Text = "";
            lblTotalInstrumentos.Text = "";
            lblTotalInstrumentos.Visible = false;
            lblInstrumentosSeleccionados.Visible = false;
            memoEmail.Text = "";
            empresaSeleccionada = null;
            contactoSeleccionado = null;
            Ingreso = new IngresoDto();
            memoEmail.Text = _textoEmail;

            instrumentosListaSeleccionados.Clear();
            instrumentosDeEmpresa.Clear();

            gcInstrumentosSeleccionados.DataSource = null;

            LimpiarContactos();
            LimpiarCorreos();
        }

        private void glUsuariosResponsables_EditValueChanged(object sender, EventArgs e)
        {
            usuarioSeleccionado = glUsuariosResponsablesView.GetFocusedRow() as UsuarioDto;
        }

        private void glContacto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(glContacto.Text)) return;

            memoEmail.Text = _textoEmail;

            contactoSeleccionado = empresaSeleccionada.Contactos.FirstOrDefault(x => x.ContactoId.Contains(glContacto.EditValue.ToString()));

            string saludo = contactoSeleccionado.Genero == (int)Generos.Masculino ? $"Estimado {contactoSeleccionado.Saludo}" : $"Estimada {contactoSeleccionado.Saludo}";

            string textoEmailSaludo = $"{saludo} {contactoSeleccionado.Nombre} {contactoSeleccionado.Apellido}.";
            memoEmail.Lines[0] = textoEmailSaludo;
            memoEmail.Text = memoEmail.Text.Replace("Estimado", textoEmailSaludo);

            if (TipoIngreso == TiposIngreso.PreIngreso) memoEmail.Text = memoEmail.Text.Replace("recibido el instrumento", "realizado un Pre-Ingreso de instrumento(s)");

            ObtenerCorreoElectronicoDeContacto();
        }

        private void glEstado_EditValueChanged(object sender, EventArgs e)
        {
            estadoSeleccionado = glEstadoView.GetFocusedRow() as EstadoDto;
        }

        private void txtEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                serviceProvider = Program.services.BuildServiceProvider();
                var frmEmpresas = new frmEmpresas(serviceProvider.GetService<EmpresaService>());
                frmEmpresas.OnSeleccionaEmpresa += OnEmpresaSeleccionada;
                frmEmpresas.txtBusqueda.Text = txtEmpresa.Text;
                frmEmpresas.CargarDatosDeEmpresas();
                frmEmpresas.ShowDialog();
            }
        }

        private void toggleTipoVista_Toggled(object sender, EventArgs e)
        {
            if (toggleTipoVista.IsOn)
            {
                navigationFrame1.SelectedPage = pageAcordion;

                pnlEmpresa.Dock = DockStyle.Fill;
                pnlEmpresa.Parent = accordionContainerInfoBasica;
                pnlEmpresa.BringToFront();

                pnlInstrumentos.Dock = DockStyle.Fill;
                pnlInstrumentos.Parent = accordionContainerInstrumentos;
                pnlInstrumentos.BringToFront();

                pnlFinal.Dock = DockStyle.Fill;
                pnlFinal.Parent = accordionContainerFaseFinalIngreso;
                pnlFinal.BringToFront();

                return;
            }

            navigationFrame1.SelectedPage = pagePestanias;

            pnlEmpresa.Dock = DockStyle.Fill;
            pnlEmpresa.Parent = tabInfoBasicaCliente;
            pnlEmpresa.BringToFront();

            pnlInstrumentos.Dock = DockStyle.Fill;
            pnlInstrumentos.Parent = tabInstrumentos;
            pnlInstrumentos.BringToFront();

            pnlFinal.Dock = DockStyle.Fill;
            pnlFinal.Parent = tabFaseFinal;
            pnlFinal.BringToFront();
        }
    }
}

