using AutomatMediciones.DesktopApp.Componentes.Encabezados;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Ingresos.Dtos;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Ingresos
{
    public partial class frmInformacionAdicionalInstrumento : DevExpress.XtraEditors.XtraForm
    {
        public delegate void InformacionAdicionalAgregada(Dtos.InstrumentoLista instrumento);
        public event InformacionAdicionalAgregada OnInformacionAdicionalAgregada;

        public delegate void InformacionAdicionalActualizada(Dtos.InstrumentoLista instrumento);
        public event InformacionAdicionalActualizada OnInformacionAdicionalActualizada;

        TipoTrabajoDto tipoTrabajoSeleccionado;
        private readonly TipoTrabajoService _tipoTrabajoService;

        public List<TipoTrabajoDto> TiposDeTrabajo { get; set; }

        public TipoTransaccion TipoTransaccion { get; set; }

        public InstrumentoLista Instrumento { get; set; }
        public frmInformacionAdicionalInstrumento(TipoTransaccion tipoTransaccion, TipoTrabajoService tipoTrabajoService)
        {
            InitializeComponent();
            _tipoTrabajoService = tipoTrabajoService;

            TipoTransaccion = tipoTransaccion;
            tipoTrabajoSeleccionado = new TipoTrabajoDto();
            Instrumento = new InstrumentoLista();

            EstablecerColorBotonGuardar();
            EstablecerNombreYTituloDePantalla();

            CargarDatosTiposDeTrabajo();
        }

        private void EstablecerNombreYTituloDePantalla()
        {
            string titulo = "";
            this.Text = titulo;

            ctlEncabezadoPantalla ctlEncabezadoPantalla3 = new ctlEncabezadoPantalla();
            ctlEncabezadoPantalla3.Parent = this;
            ctlEncabezadoPantalla3.Height = 43;
            ctlEncabezadoPantalla3.Dock = DockStyle.Top;
            ctlEncabezadoPantalla3.lblTitulo.Text = "Información de Ingreso para Instrumento";
            ctlEncabezadoPantalla3.EstablecerColoresDeFondoYLetra();
        }

        private void CargarDatosTiposDeTrabajo()
        {
            var resultado = _tipoTrabajoService.ObtenerTiposDeTrabajo();

            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            TiposDeTrabajo = resultado.Data;
            glTiposTrabajo.Properties.DataSource = resultado.Data;
            glTiposTrabajo.Properties.DisplayMember = "Descripcion";
            glTiposTrabajo.Properties.ValueMember = "TipoTrabajoId";
        }

        private void EstablecerColorBotonGuardar()
        {
            btnIngresarInformacionAdicional.BackColor = ColorHelper.ObtenerColorEnRGB("Sucess");
            btnIngresarInformacionAdicional.ForeColor = ColorHelper.ObtenerColorEnRGB("Primary50");
            btnIngresarInformacionAdicional.IconColor = ColorHelper.ObtenerColorEnRGB("Primary50");
        }

        private void btnIngresarComentario_Click(object sender, EventArgs e)
        {
            if (tipoTrabajoSeleccionado == null)
            {
                return;
            }


            if (tipoTrabajoSeleccionado.TipoTrabajoId == 0)
            {
                Notificaciones.MensajeAdvertencia("Es necesario que seleccione un tipo de trabajo.");
                return;
            }

            Instrumento.InformacionAdicional = new InformacionAdicionalInstrumento();

            Instrumento.InformacionAdicional.ComentariosAcercaDelInstrumento = memoComentariosInstrumento.Text;
            Instrumento.InformacionAdicional.Comentarios = memoComentarios.Text;
            Instrumento.InformacionAdicional.Prioridad = trackBarControl1.Value;
            Instrumento.InformacionAdicional.TipoTrabajoId = tipoTrabajoSeleccionado.TipoTrabajoId;
            Instrumento.InformacionAdicional.FechaEntregaRequerida = dateFechaEntregaRequerida.Value;
            Instrumento.InformacionAdicional.TipoTrabajo = tipoTrabajoSeleccionado;
           
            if (TipoTransaccion == TipoTransaccion.Actualizar)
            {
                OnInformacionAdicionalActualizada?.Invoke(Instrumento);
            }
            else
            {
                OnInformacionAdicionalAgregada?.Invoke(Instrumento);
            }

            this.Close();
            ResetearCampos();

        }

        private void ResetearCampos()
        {
            memoComentarios.Text = "";
            trackBarControl1.Value = 1;
           
        }

        public void SetearInformacionAdicionalParaActualizar(IngresoInstrumentoDto ingresoInstrumentoDto, bool seleccionado)
        {
            Instrumento = new InstrumentoLista();
            glTiposTrabajo.EditValue = ingresoInstrumentoDto.TipoTrabajoId;
            tipoTrabajoSeleccionado = TiposDeTrabajo.FirstOrDefault(x => x.TipoTrabajoId == ingresoInstrumentoDto.TipoTrabajoId);       
            memoComentarios.Text = ingresoInstrumentoDto.Comentarios;
            memoComentariosInstrumento.Text = ingresoInstrumentoDto.ComentariosAcercaDelInstrumento;
            trackBarControl1.Value = ingresoInstrumentoDto.Prioridad;
           


            Instrumento.Seleccionado = seleccionado;
            Instrumento.InstrumentoId = ingresoInstrumentoDto.InstrumentoId;
        }

        private void glTiposTrabajo_EditValueChanged(object sender, EventArgs e)
        {
            tipoTrabajoSeleccionado = glTiposTrabajoView.GetFocusedRow() as TipoTrabajoDto;
        }
    }
}