using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Ingresos.Dtos;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using Nagaira.Herramientas.Standard.Helpers.Responses;
using System;
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

        public TipoTransaccion TipoTransaccion { get; set; }

        public InstrumentoLista Instrumento { get; set; }
        public frmInformacionAdicionalInstrumento(TipoTransaccion tipoTransaccion, TipoTrabajoService tipoTrabajoService)
        {
            InitializeComponent();
            _tipoTrabajoService = tipoTrabajoService;

            TipoTransaccion = tipoTransaccion;

            CargarDatosTiposDeTrabajo();
        }

        private void CargarDatosTiposDeTrabajo()
        {
            var resultado = _tipoTrabajoService.ObtenerTiposDeTrabajo();

            if (resultado.Type != TypeResponse.Ok) Notificaciones.MensajeError(resultado.Message);

            glTiposTrabajo.Properties.DataSource = resultado.Data;
            glTiposTrabajo.Properties.DisplayMember = "Descripcion";
            glTiposTrabajo.Properties.ValueMember = "TipoTrabajoId";
        }

        private void btnIngresarComentario_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrEmpty(memoComentarios.Text))
            {
                Notificaciones.MensajeAdvertencia("Es necesario que ingrese un comentario.");
                return;
            }

            Instrumento.InformacionAdicional.Comentarios = memoComentarios.Text;
            Instrumento.InformacionAdicional.Prioridad = trackBarControl1.Value;
            Instrumento.InformacionAdicional.TipoTrabajoId = tipoTrabajoSeleccionado.TipoTrabajoId;
            Instrumento.InformacionAdicional.FechaEntregaRequerida = dateFechaEntregaRequerida.Value;

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
            glTiposTrabajo.EditValue = null;
        }

        public void SetearInformacionAdicionalParaActualizar(IngresoInstrumentoDto ingresoInstrumentoDto)
        {
            memoComentarios.Text = ingresoInstrumentoDto.Comentarios;
            trackBarControl1.Value = ingresoInstrumentoDto.Prioridad;
            glTiposTrabajo.EditValue = ingresoInstrumentoDto.TipoTrabajoId;
        }

        private void glTiposTrabajo_EditValueChanged(object sender, EventArgs e)
        {
            tipoTrabajoSeleccionado = glTiposTrabajoView.GetFocusedRow() as TipoTrabajoDto;
        }
    }
}