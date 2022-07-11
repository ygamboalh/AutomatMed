using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.CertificadosDeCalibracion;
using AutomatMediciones.DesktopApp.Pantallas.Diagnosticos.Dtos;
using AutomatMediciones.DesktopApp.Pantallas.Ingresos.Dtos;
using AutomatMediciones.DesktopApp.Pantallas.Instrumentos;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;

namespace AutomatMediciones.DesktopApp.Pantallas.Diagnosticos
{
    public partial class frmNuevoDiagnostico : DevExpress.XtraEditors.XtraForm
    {
        ServiceProvider serviceProvider = Program.services.BuildServiceProvider();

        private readonly UsuarioService _usuarioService;
        private readonly EstadoService _estadoService;
        private readonly IngresoService _ingresoService;
        private readonly ConfiguracionNotificacionService _configuracionNotificacionService;

        ConfiguracionNotificacionDto configuracionNotificacion;

        public delegate void DignosticoGuardado(IngresoInstrumento ingresoInstrumento);
        public event DignosticoGuardado OnDiagnosticoAgregado;

        UsuarioDto usuarioSeleccionado;
        EstadoDto estadoSeleccionado;

        int v_segundos;
        int v_minutos;
        int v_hora;
        string v_tiempo;
        public IngresoInstrumento IngresoInstrumento { get; set; }
        public frmNuevoDiagnostico(IngresoInstrumento ingresoInstrumento, UsuarioService usuarioService, EstadoService estadoService, IngresoService ingresoService, ConfiguracionNotificacionService configuracionNotificacionService)
        {
            InitializeComponent();
            IngresoInstrumento = ingresoInstrumento;
            _usuarioService = usuarioService;
            _estadoService = estadoService;
            _ingresoService = ingresoService;
            _configuracionNotificacionService = configuracionNotificacionService;
            EstablecerNombreYTitulo();
            EstablecerColorBotonGuardar();
            EstablecerColorBotonPorDefecto();

            CargarUsuarios();
            CargarEstados();
            CargarConfiguraciones();
            PrecargarDatos();

            if (IngresoInstrumento.FechaFin != null)
            {
                lblTiempo.Text = $"{v_hora}:{v_minutos}:{v_segundos}";
            }
            else
            {
                timer1.Enabled = true;
                timer1.Start();
            }

        }

        private void CargarConfiguraciones()
        {
            var resultado = _configuracionNotificacionService.ObtenerConfiguraciones();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            configuracionNotificacion = resultado.Data;
        }


        private void PrecargarDatos()
        {
            var tipoInstrumento = IngresoInstrumento.Instrumento.Clasificacion.TipoInstrumento.Descripcion;
            var marca = IngresoInstrumento.Instrumento.Clasificacion.Marca.Descripcion;
            var modelo = IngresoInstrumento.Instrumento.Clasificacion.Modelo.Descripcion;
            var serie = IngresoInstrumento.Instrumento.NumeroSerie;

            txtContactoACargo.Text = $"{IngresoInstrumento.Ingreso.NombreContacto} {IngresoInstrumento.Ingreso.ApellidoContacto}";
            txtCliente.Text = IngresoInstrumento.Ingreso.NombreEmpresa;
            txtNumeroServicioTecnico.Text = IngresoInstrumento.NumeroServicioTecnico;
            glUsuariosResponsables.EditValue = IngresoInstrumento.ResponsableId;
            usuarioSeleccionado = IngresoInstrumento.Ingreso.Responsable;
            txtClasificacion.Text = $"{tipoInstrumento} / {marca} / {modelo} - Serie: {serie}";
            txtTipoOrdenTrabajo.Text = IngresoInstrumento.TipoTrabajo.Descripcion;
            txtPrioridad.Text = IngresoInstrumento.Prioridad.ToString();
            glEstado.EditValue = IngresoInstrumento.EstadoId;
            memoComentarios.Text = IngresoInstrumento.Comentarios;
            memoDiagnostico.Text = IngresoInstrumento.Diagnostico;

            IngresoInstrumento.FechaInicio = IngresoInstrumento.FechaInicio == null ? DateTime.Now : IngresoInstrumento.FechaInicio;
            memoComentariosInstrumento.Text = IngresoInstrumento.Instrumento.Comentarios;

            if (IngresoInstrumento.TiempoConsumido == null)
            {
                v_segundos = 0;
                v_minutos = 0;
                v_hora = 0;
            }
            else
            {
                v_segundos = Convert.ToInt32(IngresoInstrumento.TiempoConsumido.Value.Seconds);
                v_minutos = Convert.ToInt32(IngresoInstrumento.TiempoConsumido.Value.Minutes);
                v_hora = Convert.ToInt32(IngresoInstrumento.TiempoConsumido.Value.Hours);
            }
        }

        private void EstablecerColorBotonPorDefecto()
        {
            btnPrepararCertificado.BackColor = ColorHelper.ObtenerColorEnRGB("Default");
            btnPrepararCertificado.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnPrepararCertificado.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void EstablecerColorBotonGuardar()
        {
            btnGuardarDiagnostico.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnGuardarDiagnostico.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnGuardarDiagnostico.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void EstablecerNombreYTitulo()
        {
            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 40;
            ctlEncabezadoPantalla3.Dock = System.Windows.Forms.DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Diagnóstico";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }

        private void btnGuardarDiagnostico_Click(object sender, System.EventArgs e)
        {
            GuardarDiagnostico();
        }

        private void GuardarDiagnostico()
        {
            if (memoDiagnostico.Text.Length == 0)
            {
                Notificaciones.MensajeAdvertencia("¡Es necesario que ingrese un diagnóstico!");
                return;
            }

            if (usuarioSeleccionado == null)
            {
                Notificaciones.MensajeAdvertencia("¡Es necesario que seleccione un responsable!");
                return;
            }

            var resultIngresoActual = _ingresoService.ObtenerIngresoInstrumento(IngresoInstrumento.IngresoInstrumentoId);
            if (resultIngresoActual.Type != TypeResponse.Ok) { Notificaciones.MensajeAdvertencia("¡Es necesario que seleccione un responsable!"); return; }

            var responsableActual = resultIngresoActual.Data.ResponsableId;

            IngresoInstrumento.Instrumento.Comentarios = memoComentariosInstrumento.Text;
            IngresoInstrumento.FechaQueEstaraDisponible = dateFechaDisponible.EditValue != null ? (DateTime)dateFechaDisponible.EditValue : null;
            IngresoInstrumento.Comentarios = memoComentarios.Text;
            IngresoInstrumento.Diagnostico = memoDiagnostico.Text;
            IngresoInstrumento.EstadoId = estadoSeleccionado == null ? IngresoInstrumento.EstadoId : estadoSeleccionado.EstadoId;
            IngresoInstrumento.ResponsableId = usuarioSeleccionado.UsuarioId;
            IngresoInstrumento.TiempoConsumido = new TimeSpan(v_hora, v_minutos, v_segundos);
            IngresoInstrumento.FechaFin = DateTime.Now;

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));

            if ((ActualizarClasificacionInstrumento()))
            {
                if (responsableActual != usuarioSeleccionado.UsuarioId)
                {
                    var correoHelper = new CorreoHelper();

                    if (correoHelper.EnviarCorreo(PrepararCorreo()))
                    {
                        Notificaciones.MensajeConfirmacion("¡El diagnóstico se ha registrado exitosamente!");
                    }
                    else
                    {
                        Notificaciones.MensajeConfirmacion("El diagnóstico se ha registrado exitosamente, pero, hubo una falla en el momento de enviar la notificación por correo a la persona responsable.");
                    }
                }
                else
                {
                    Notificaciones.MensajeConfirmacion("¡El diagnóstico se ha registrado exitosamente!");
                }


                OnDiagnosticoAgregado?.Invoke(IngresoInstrumento);
                timer1.Stop();
                this.Close();
            }

            SplashScreenManager.CloseForm();
        }

        private CorreoNotificacionCambioResponsableDto PrepararCorreo()
        {
            configuracionNotificacion.Asunto = $"Asignación de Servicio Técnico #{IngresoInstrumento.NumeroServicioTecnico}";

            string body = "";

            body = $"<p>¡Hola! Le notificamos que el Servicio Técnico #{IngresoInstrumento.NumeroServicioTecnico} con estado {IngresoInstrumento.Estado.Descripcion} le ha sido asignado. </p>";
            body += $"<p><strong>Empresa:</strong> {IngresoInstrumento.Ingreso.NombreEmpresa} </p>";
            body += $"<p><strong>Tipo de Trabajo:</strong> {IngresoInstrumento.TipoTrabajo.Descripcion} </p>";
            body += $"<p><strong>Tipo de Instrumento:</strong> {IngresoInstrumento.Instrumento.Clasificacion.TipoInstrumento.Descripcion} </p>";
            body += $"<p><strong>Marca:</strong> {IngresoInstrumento.Instrumento.Clasificacion.Marca.Descripcion} </p>";
            body += $"<p><strong>Modelo:</strong> {IngresoInstrumento.Instrumento.Clasificacion.Modelo.Descripcion} </p>";
            body += $"<p><strong>Observaciones acerca del Instrumento:</strong> {IngresoInstrumento.Instrumento.Comentarios} </p>";
            body += $"<p><strong>Detalle o Problema:</strong> {IngresoInstrumento.Comentarios}";

            CorreoNotificacionCambioResponsableDto correoNotificacionDto = new CorreoNotificacionCambioResponsableDto
            {
                Body = body,
                CorreoDestinatario = usuarioSeleccionado.Correo,
                NombreDestinatario = usuarioSeleccionado.Nombre,
                Configuracion = configuracionNotificacion
            };

            return correoNotificacionDto;
        }

        private void CargarUsuarios()
        {
            var resultado = _usuarioService.ObtenerUsuariosActivos();
            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            var usuarios = resultado.Data;

            glUsuariosResponsables.Properties.DataSource = usuarios;
            glUsuariosResponsables.Properties.DisplayMember = "Nombre";
            glUsuariosResponsables.Properties.ValueMember = "UsuarioId";
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

        private bool ActualizarClasificacionInstrumento()
        {
            try
            {
                var resultado = _ingresoService.ActualizarDiagnostico(IngresoInstrumento);
                if (resultado.Type != TypeResponse.Ok) return false;

                return true;
            }
            catch (Exception exc)
            {
                Notificaciones.MensajeError(ExceptionsHelper.ObtenerMensajeExcepcion(exc));
                return false;
            }
        }

        private void glEstado_EditValueChanged(object sender, EventArgs e)
        {
            estadoSeleccionado = glEstadoView.GetFocusedRow() as EstadoDto;
        }

        private void glUsuariosResponsables_EditValueChanged(object sender, EventArgs e)
        {
            usuarioSeleccionado = glUsuariosResponsablesView.GetFocusedRow() as UsuarioDto;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            v_segundos++;
            v_tiempo = "";

            if (v_minutos == 60)
            {
                v_minutos = 0;
                v_hora++;
                v_tiempo += "0" + v_hora;
            }
            else
            {
                if (v_hora < 10)
                {
                    v_tiempo += "0" + v_hora;
                }
                else
                {
                    v_tiempo += v_hora;
                }
            }

            v_tiempo += ":";

            if (v_segundos >= 60)
            {
                v_segundos = 0;
                v_minutos++;
                v_tiempo += "0" + v_minutos;
            }
            else
            {
                if (v_minutos < 10)
                {
                    v_tiempo += "0" + v_minutos;
                }
                else
                {
                    v_tiempo += v_minutos;
                }
            }

            v_tiempo += ":";

            if (v_segundos < 10)
            {
                v_tiempo += "0" + v_segundos;
            }
            else
            {
                v_tiempo += v_segundos;
            }

            lblTiempo.Text = v_tiempo;


        }

        private void frmNuevoDiagnostico_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            timer1.Stop();
            IngresoInstrumento.TiempoConsumido = new TimeSpan(v_hora, v_minutos, v_segundos);
            _ingresoService.ActualizarFechaUltimoIngreso(IngresoInstrumento);
            OnDiagnosticoAgregado?.Invoke(IngresoInstrumento);
        }

        private void btnPrepararCertificado_Click(object sender, EventArgs e)
        {
            serviceProvider = Program.services.BuildServiceProvider();
            var frmNuevoCertificadoCalibracion = new frmNuevoCertificadoCalibracion(IngresoInstrumento.InstrumentoId,
                serviceProvider.GetService<CertificadoCalibracionService>(),
                 serviceProvider.GetService<UsuarioService>(),
                 serviceProvider.GetService<PatronService>(),
                 serviceProvider.GetService<InstrumentoService>()
                );
            frmNuevoCertificadoCalibracion.ShowDialog();
        }

        private void frmNuevoDiagnostico_Load(object sender, EventArgs e)
        {

        }

        private void btnDetalleInstrumento_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            var frmNuevoInstrumento = new frmNuevoInstrumento(TipoTransaccion.Actualizar, serviceProvider.GetService<ClasificacionInstrumentoService>(),
                                                                            serviceProvider.GetService<InstrumentoService>(),
                                                                            serviceProvider.GetService<MarcaService>(),
                                                                            serviceProvider.GetService<ModeloService>(),
                                                                            serviceProvider.GetService<TipoDeInstrumentoService>(),
                                                                            serviceProvider.GetService<EmpresaService>(),
                                                                            serviceProvider.GetService<CeldaService>());

            //frmNuevoInstrumento.OnInstrumentoModificado += onInstrumentoModificado;
            frmNuevoInstrumento.NuevoInstrumento = IngresoInstrumento.Instrumento;
            frmNuevoInstrumento.CargarVariablesInstrumentos();
            frmNuevoInstrumento.SetearValoresParaActualizar();
            SplashScreenManager.CloseForm();
            frmNuevoInstrumento.ShowDialog();
        }

        private void btnHistorialDeCertificados_Click(object sender, EventArgs e)
        {
            var frmHistorialCertificados = new frmCertificadosDeCalibracion(serviceProvider.GetService<CertificadoCalibracionService>());
            frmHistorialCertificados.InstrumentoId = IngresoInstrumento.InstrumentoId;
            frmHistorialCertificados.CargarCertificadosDeCalibracionPorInstrumento();
            frmHistorialCertificados.ShowDialog();
        }
    }
}