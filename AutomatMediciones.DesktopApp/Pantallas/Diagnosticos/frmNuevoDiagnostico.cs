using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Diagnosticos.Dtos;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using DevExpress.XtraSplashScreen;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;

namespace AutomatMediciones.DesktopApp.Pantallas.Diagnosticos
{
    public partial class frmNuevoDiagnostico : DevExpress.XtraEditors.XtraForm
    {
        private readonly UsuarioService _usuarioService;
        private readonly EstadoService _estadoService;
        private readonly IngresoService _ingresoService;

        public delegate void DignosticoGuardado(IngresoInstrumento ingresoInstrumento);
        public event DignosticoGuardado OnDiagnosticoAgregado;

        UsuarioDto usuarioSeleccionado;
        EstadoDto estadoSeleccionado;

        int v_segundos;
        int v_minutos;
        int v_hora;
        string v_tiempo;
        public IngresoInstrumento IngresoInstrumento { get; set; }
        public frmNuevoDiagnostico(IngresoInstrumento ingresoInstrumento, UsuarioService usuarioService, EstadoService estadoService, IngresoService ingresoService)
        {
            InitializeComponent();
            IngresoInstrumento = ingresoInstrumento;
            _usuarioService = usuarioService;
            _estadoService = estadoService;
            _ingresoService = ingresoService;
            EstablecerNombreYTitulo();
            EstablecerColorBotonGuardar();

            CargarUsuarios();
            CargarEstados();
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

        private void PrecargarDatos()
        {
            txtMarca.Text = IngresoInstrumento.Instrumento.Clasificacion.Marca.Descripcion;
            txtModelo.Text = IngresoInstrumento.Instrumento.Clasificacion.Modelo.Descripcion;
            txtTipoInstrumento.Text = IngresoInstrumento.Instrumento.Clasificacion.TipoInstrumento.Descripcion;
            txtTipoOrdenTrabajo.Text = IngresoInstrumento.TipoTrabajo.Descripcion;
            txtPrioridad.Text = IngresoInstrumento.Prioridad.ToString();
            glEstado.EditValue = IngresoInstrumento.EstadoId;
            memoComentarios.Text = IngresoInstrumento.Comentarios;
            memoDiagnostico.Text = IngresoInstrumento.Diagnostico;
            glUsuariosResponsables.EditValue = IngresoInstrumento.ResponsableId;
            IngresoInstrumento.FechaInicio = IngresoInstrumento.FechaInicio == null ? DateTime.Now : IngresoInstrumento.FechaInicio;

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
            ctlEncabezadoPantalla3.Height = 43;
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

            IngresoInstrumento.Comentarios = memoComentarios.Text;
            IngresoInstrumento.Diagnostico = memoDiagnostico.Text;
            IngresoInstrumento.EstadoId = estadoSeleccionado == null ? IngresoInstrumento.EstadoId : estadoSeleccionado.EstadoId;
            IngresoInstrumento.ResponsableId = usuarioSeleccionado == null ? IngresoInstrumento.ResponsableId : usuarioSeleccionado.UsuarioId;
            IngresoInstrumento.TiempoConsumido = new TimeSpan(v_hora, v_minutos, v_segundos);
            IngresoInstrumento.FechaFin = DateTime.Now;

            SplashScreenManager.ShowForm(typeof(frmLoadingSave));

            if ((ActualizarClasificacionInstrumento()))
            {
                Notificaciones.MensajeConfirmacion("¡El diagnóstico se ha registrado exitosamente!");
                OnDiagnosticoAgregado?.Invoke(IngresoInstrumento);
                timer1.Stop();
                this.Close();
            }

            SplashScreenManager.CloseForm();
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
    }
}