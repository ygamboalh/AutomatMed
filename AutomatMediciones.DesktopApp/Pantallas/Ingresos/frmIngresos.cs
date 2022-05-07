using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Ingresos.Dtos;
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
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Ingresos
{
    public partial class frmIngresos : DevExpress.XtraEditors.XtraForm
    {
        ContactoDto contactoSeleccionado;
        EmpresaDto empresaSeleccionada;
        CorreoElectronicoDto correoSeleccionado;
        UsuarioDto usuarioSeleccionado;
        EstadoDto estadoSeleccionado;

        private ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private readonly IngresoService _ingresoService;
        private readonly InstrumentoService _instrumentoService;
        private readonly UsuarioService _usuarioService;
        private readonly ConfiguracionNotificacionService _configuracionNotificacionService;
        private readonly EstadoService _estadoService;

        ICollection<IngresoInstrumentoDto> instrumentosSeleccionados;

        List<UsuarioDto> copiasEnCorreo;
        List<InstrumentoLista> instrumentosDeEmpresa;
        ConfiguracionNotificacionDto configuracionNotificacion;

        public IngresoDto Ingreso { get; set; }

        public frmIngresos(IngresoService ingresoService, InstrumentoService instrumentoService, 
                           UsuarioService usuarioService, ConfiguracionNotificacionService configuracionNotificacionService, EstadoService estadoService)
        {
            InitializeComponent();

            Cursor.Current = Cursors.WaitCursor;

            _ingresoService = ingresoService;
            _instrumentoService = instrumentoService;
            _usuarioService = usuarioService;
            _configuracionNotificacionService = configuracionNotificacionService;
            _estadoService = estadoService;

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

            instrumentosSeleccionados = new List<IngresoInstrumentoDto>();
            instrumentosDeEmpresa = new List<InstrumentoLista>();

            chkSeleccionarInstrumento.EditValueChanged += onSeleccionaInstrumento;
            btnEditarComentario.Click += clickEditarComentario;
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

            var estados = resultado.Data;

            glEstado.Properties.DataSource = estados;
            glEstado.Properties.DisplayMember = "Descripcion";
            glEstado.Properties.ValueMember = "EstadoId";
        }

        private void CargarUsuarios()
        {
            var resultado = _usuarioService.ObtenerUsuariosActivos();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var usuarios = resultado.Data;

            copiasEnCorreo = usuarios.Where(x => x.CopiaEnNotificaciones).ToList();

            glUsuariosResponsables.Properties.DataSource = usuarios;
            glUsuariosResponsables.Properties.DisplayMember = "Nombre";
            glUsuariosResponsables.Properties.ValueMember = "UsuarioId";
        }

        private void clickEditarComentario(object sender, EventArgs e)
        {

            var instrumento = gvInstrumentosDeEmpresa.GetFocusedRow() as Dtos.InstrumentoLista;
            if (instrumento == null)
            {              
                return;
            }

            var ingresoInstrumento = instrumentosSeleccionados.FirstOrDefault(x => x.InstrumentoId.Equals(instrumento.InstrumentoId));
            if (ingresoInstrumento == null)
            {
                Notificaciones.MensajeAdvertencia("El instrumento que intenta editar no ha sido seleccionado.");
                return;
            }

            frmInformacionAdicionalInstrumento frmComentarioInstrumento = new frmInformacionAdicionalInstrumento(TipoTransaccion.Actualizar, serviceProvider.GetService<TipoTrabajoService>());
            frmComentarioInstrumento.OnInformacionAdicionalActualizada += OnInformacionAdicionalActualizada;
            frmComentarioInstrumento.SetearInformacionAdicionalParaActualizar(ingresoInstrumento, instrumento.Seleccionado);
            frmComentarioInstrumento.Show();
        }

        private void OnInformacionAdicionalActualizada(InstrumentoLista instrumento)
        {
            
            AccionPorRealizarDespuesDeSeleccion(instrumento);
           
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
                frmInformacionAdicionalInstrumento frmComentarioInstrumento = new frmInformacionAdicionalInstrumento(TipoTransaccion.Insertar, serviceProvider.GetService<TipoTrabajoService>());
                frmComentarioInstrumento.OnInformacionAdicionalAgregada += OnInformacionAgregada;
                frmComentarioInstrumento.Instrumento = instrumento;
                frmComentarioInstrumento.Instrumento.InformacionAdicional = new InformacionAdicionalInstrumento();
                frmComentarioInstrumento.Show();
            }
            else
            {
                AccionPorRealizarDespuesDeSeleccion(instrumento);
            }
        }

        private void OnInformacionAgregada(InstrumentoLista instrumento)
        {
            AccionPorRealizarDespuesDeSeleccion(instrumento);
        }

        private void AccionPorRealizarDespuesDeSeleccion(InstrumentoLista instrumento)
        {

            var yaFueSeleccionado = YaFueSeleccionadoElInstrumento(instrumento.InstrumentoId);
            if (!instrumento.Seleccionado && yaFueSeleccionado) QuitarInstrumentoDeListaDeSeleccionados(instrumento.InstrumentoId);

            if (instrumento.Seleccionado && !yaFueSeleccionado) AgregarInstrumentoEnListaDeSeleccionados(instrumento);

            if (instrumento.Seleccionado && yaFueSeleccionado)
            {
                instrumentosSeleccionados.ToList().ForEach(x =>
                {
                    if (x.InstrumentoId == instrumento.InstrumentoId)
                    {
                        x.ComentariosAcercaDelInstrumento = instrumento.InformacionAdicional.ComentariosAcercaDelInstrumento;
                        x.Comentarios = instrumento.InformacionAdicional.Comentarios;
                        x.Prioridad = instrumento.InformacionAdicional.Prioridad;
                        x.TipoTrabajoId = instrumento.InformacionAdicional.TipoTrabajoId;
                        x.FechaEntregaRequerida = instrumento.InformacionAdicional.FechaEntregaRequerida.Value;
                        x.InstrumentoId = instrumento.InstrumentoId;
                        x.Activo = true;
                    }
                });


                instrumentosDeEmpresa.ForEach(x =>
                {
                    if (x.InstrumentoId == instrumento.InstrumentoId)
                    {
                        x.InformacionAdicional.TipoTrabajo = instrumento.InformacionAdicional.TipoTrabajo;
                        x.InformacionAdicional.Comentarios = instrumento.InformacionAdicional.Comentarios;
                        x.InformacionAdicional.ComentariosAcercaDelInstrumento = instrumento.InformacionAdicional.ComentariosAcercaDelInstrumento;
                        x.InformacionAdicional.FechaEntregaRequerida = instrumento.InformacionAdicional.FechaEntregaRequerida;
                        x.InformacionAdicional.Prioridad = instrumento.InformacionAdicional.Prioridad;
                        x.InformacionAdicional.TipoTrabajoId = instrumento.InformacionAdicional.TipoTrabajoId;

                    }
                });


                gcInstrumentosDeEmpresa.RefreshDataSource();


            }

            lblInstrumentosSeleccionados.Text = $"Instrumentos Seleccionados: {instrumentosSeleccionados.Count}";
        }

        private void AgregarInstrumentoEnListaDeSeleccionados(InstrumentoLista instrumento)
        {
            var ingresoInstrumento = new IngresoInstrumentoDto
            {               
                ComentariosAcercaDelInstrumento = instrumento.InformacionAdicional.ComentariosAcercaDelInstrumento,
                Comentarios = instrumento.InformacionAdicional.Comentarios,
                Prioridad = instrumento.InformacionAdicional.Prioridad,
                TipoTrabajoId = instrumento.InformacionAdicional.TipoTrabajoId,
                FechaEntregaRequerida = instrumento.InformacionAdicional.FechaEntregaRequerida.Value,
                InstrumentoId = instrumento.InstrumentoId,
                Activo = true
            };

            instrumentosSeleccionados.Add(ingresoInstrumento);

            ActualizarSeleccionDeInstrumento(instrumentosDeEmpresa.FirstOrDefault(x => x.InstrumentoId == instrumento.InstrumentoId));
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

        private List<InstrumentoDto> ObtenerInstrumentosParaEmpresaSeleccionada()
        {
            var resultado = _instrumentoService.ObtenerInstrumentos(empresaSeleccionada.NombreEmpresa);
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            return resultado.Data;
        }

        private void ActualizarSeleccionDeInstrumento(InstrumentoLista instrumentoLista)
        {
            instrumentosDeEmpresa.FirstOrDefault(x => x.InstrumentoId == instrumentoLista.InstrumentoId).Seleccionado = instrumentoLista.Seleccionado;
            instrumentosDeEmpresa.FirstOrDefault(x => x.InstrumentoId == instrumentoLista.InstrumentoId).InformacionAdicional = instrumentoLista.InformacionAdicional;
            instrumentosDeEmpresa.FirstOrDefault(x => x.InstrumentoId == instrumentoLista.InstrumentoId).ClasificacionConcatenada = $"{instrumentoLista.Clasificacion.TipoInstrumento.Descripcion}/{instrumentoLista.Clasificacion.Marca.Descripcion}/{instrumentoLista.Clasificacion.Modelo.Descripcion}";

            instrumentosDeEmpresa.ForEach(x =>
            {
                if (!x.Seleccionado)
                {
                    x.InformacionAdicional = new InformacionAdicionalInstrumento();
                }
            });

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
            string titulo = "Ingresos";
            this.Text = titulo;

            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Creación de Ingreso";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
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
        }

        private void LimpiarCorreos()
        {
            glCorreoElectronico.Properties.DataSource = null;
        }

        private void btnAgregarNuevInstrumento_Click(object sender, EventArgs e)
        {
            frmNuevoInstrumento frmNuevoInstrumento = new frmNuevoInstrumento(TipoTransaccion.Insertar, serviceProvider.GetService<ClasificacionInstrumentoService>(),
                                                                              serviceProvider.GetService<InstrumentoService>(),
                                                                              serviceProvider.GetService<MarcaService>(),
                                                                              serviceProvider.GetService<ModeloService>(),
                                                                              serviceProvider.GetService<TipoDeInstrumentoService>(),
                                                                              serviceProvider.GetService<EmpresaService>()
                                                                              );
            frmNuevoInstrumento.OnEmpresaSeleccionada(empresaSeleccionada);
            frmNuevoInstrumento.OnInstrumentoAgregado += OnInstrumentoAgregado;
            frmNuevoInstrumento.Show();
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
            Ingreso.CorreoElectronicoId = correoSeleccionado.RegistroId;
            Ingreso.DireccionCorreoElectronico = correoSeleccionado.Direccion;
            Ingreso.IngresosInstrumentos = instrumentosSeleccionados;
            Ingreso.CuerpoCorreo = memoComentarios.Text;
            Ingreso.UsuarioId = usuarioSeleccionado.UsuarioId;
            Ingreso.FechaRegistro = dateFechaIngreso.Value;
            Ingreso.IngresosInstrumentos.ToList().ForEach(x =>
            {
                x.EstadoId = (int)glEstado.EditValue;
            });
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

        private void btnGuardarIngreso_Click(object sender, EventArgs e)
        {
            if (!SeLlenaronCamposObligatorios(out string mensaje))
            {
                Notificaciones.MensajeAdvertencia(mensaje);
                return;
            }

            PrepararNuevoIngreso();

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));
            if (GuardarIngreso())
            {
                if (checkEnviarReporte.CheckState == CheckState.Checked)
                {
                    var correoHelper = new CorreoHelper();
                    if (correoHelper.EnviarCorreo(PrepararCorreo()))
                    {
                        Notificaciones.MensajeConfirmacion("¡El ingreso se ha guardado exitosamente!");         
                    }
                    else
                    {
                        Notificaciones.MensajeConfirmacion("El ingreso se ha guardado exitosamente, pero hubo una falla en el momento de enviar la notificación por correo electrónico.");
                    }

                    if (Notificaciones.PreguntaConfirmacion("¿Desea imprimir Reporte de Ingreso?") == DialogResult.Yes)
                    {
                        rptIngreso reporteIngreso = new rptIngreso();
                        reporteIngreso.objectDataSource1.DataSource = Ingreso;
                        reporteIngreso.DisplayName = $"Ingreso #{Ingreso.IngresoId}.pdf";
                        ReportPrintTool printTool = new ReportPrintTool(reporteIngreso);
                        printTool.ShowRibbonPreview();
                    }
                }
                else
                {
                    Notificaciones.MensajeConfirmacion("¡El ingreso se ha guardado exitosamente!");

                    if (Notificaciones.PreguntaConfirmacion("¿Desea imprimir reporte de Ingreso?") == DialogResult.Yes)
                    {
                        rptIngreso reporteIngreso = new rptIngreso();
                        reporteIngreso.objectDataSource1.DataSource = Ingreso;
                        reporteIngreso.DisplayName = $"Ingreso #{Ingreso.IngresoId}.pdf";
                        ReportPrintTool printTool = new ReportPrintTool(reporteIngreso);
                        printTool.ShowRibbonPreview();
                    }
                }

                LimpiarFormulario();
            }
            SplashScreenManager.CloseForm();
        }

        private CorreoNotificacionDto PrepararCorreo()
        {
            List<string> copias = new List<string>();

            copiasEnCorreo.ForEach(x =>
            {

                copias.Add(x.Correo);
            });

            rptIngreso reporteIngreso = new rptIngreso();
            reporteIngreso.objectDataSource1.DataSource = Ingreso;
            reporteIngreso.DisplayName = $"Ingreso #{Ingreso.IngresoId}.pdf";

            MemoryStream reportStream = new MemoryStream();
            reporteIngreso.ExportToPdf(reportStream);

            var diccionarioAdjuntos = new Dictionary<string, Stream>();
            diccionarioAdjuntos.Add(reporteIngreso.DisplayName, reportStream);

            CorreoNotificacionDto correoNotificacionDto = new CorreoNotificacionDto
            {
                Body = memoComentarios.Text,
                NombreEmpresa = empresaSeleccionada.NombreEmpresa,
                NombreDestinatario = contactoSeleccionado.Nombre,
                CorreoDestinatario = correoSeleccionado.Direccion,
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

        private void LimpiarFormulario()
        {
            txtEmpresa.ResetText();
            glContacto.EditValue = null;
            glCorreoElectronico.EditValue = null;
            glUsuariosResponsables.EditValue = null;
            glEstado.EditValue = null;
            instrumentosSeleccionados.Clear();
            gcInstrumentosDeEmpresa.DataSource = null;
            lblInstrumentosSeleccionados.Text = "";
            lblTotalInstrumentos.Text = "";
            lblTotalInstrumentos.Visible = false;
            lblInstrumentosSeleccionados.Visible = false;
            memoComentarios.Text = "";
            empresaSeleccionada = null;
            contactoSeleccionado = null;
            correoSeleccionado = null;
            Ingreso = new IngresoDto();
        }

        private void btnAgregarNuevInstrumento_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAgregarNuevInstrumento, "Presione para ir la a pantalla que le permite agregar un nuevo instrumento.");
        }

        private void glUsuariosResponsables_EditValueChanged(object sender, EventArgs e)
        {
            usuarioSeleccionado = glUsuariosResponsablesView.GetFocusedRow() as UsuarioDto;
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            var correoHelper = new CorreoHelper();

            if (correoHelper.EnviarCorreo(PrepararCorreo()))
            {
                Notificaciones.MensajeConfirmacion("¡El ingreso se ha guardado exitosamente!");
            }
            else
            {
                Notificaciones.MensajeConfirmacion("El ingreso se ha guardado exitosamente, pero hubo una falla en el momento de enviar la notificación por correo electrónico.");
            }
        }

        private void glContacto_TextChanged(object sender, EventArgs e)
        {
            contactoSeleccionado = empresaSeleccionada.Contactos.FirstOrDefault(x => x.Nombre.Contains(glContacto.Text));
            ObtenerCorreoElectronicoDeContacto();
        }

        private void glEstado_EditValueChanged(object sender, EventArgs e)
        {
            estadoSeleccionado = glEstadoView.GetFocusedRow() as EstadoDto;
        }
    }
}

