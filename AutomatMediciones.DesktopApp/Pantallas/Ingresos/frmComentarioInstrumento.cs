using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Ingresos.Dtos;
using Nagaira.Herramientas.Standard.Helpers.Enums;
using System;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Ingresos
{
    public partial class frmComentarioInstrumento : DevExpress.XtraEditors.XtraForm
    {
        public delegate void ComentarioAgregado(InstrumentoLista instrumento);
        public event ComentarioAgregado OnComentarioAgregado;

        public delegate void ComentarioActualizado(InstrumentoLista instrumento);
        public event ComentarioActualizado OnComentarioActualizado;

        public TipoTransaccion TipoTransaccion { get; set; }

        public InstrumentoLista Instrumento { get; set; }
        public frmComentarioInstrumento()
        {
            InitializeComponent();
        }

        private void btnIngresarComentario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(memoComentarios.Text))
            {
                Notificaciones.MensajeAdvertencia("Es necesario que ingrese un comentario.");
                return;
            }

            Instrumento.Comentarios = memoComentarios.Text;
            if (TipoTransaccion == TipoTransaccion.Actualizar)
            {
                OnComentarioActualizado?.Invoke(Instrumento);
            }
            else
            {

                OnComentarioAgregado?.Invoke(Instrumento);

            }


            this.Close();
            memoComentarios.Text = "";
        }

        public void SetearComentarioParaActualizar(string comentarios)
        {
            memoComentarios.Text = comentarios;
        }

        private void frmComentarioInstrumento_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}