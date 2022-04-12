using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Helpers
{
    public static class Notificaciones
    {

        public static void MensajeInformativo(string mensaje)
        {
            string nombreAplicacion = AplicacionHelper.ObtenerNombreDeAplicacion();
            MessageBox.Show(mensaje, nombreAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MensajeError(string mensaje)
        {
            string nombreAplicacion = AplicacionHelper.ObtenerNombreDeAplicacion();
            MessageBox.Show(mensaje, nombreAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult PreguntaConfirmacion(string mensaje)
        {
            string nombreAplicacion = AplicacionHelper.ObtenerNombreDeAplicacion();
            return MessageBox.Show(mensaje, nombreAplicacion, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void MensajeAdvertencia(string mensaje)
        {
            string nombreAplicacion = AplicacionHelper.ObtenerNombreDeAplicacion();
            MessageBox.Show(mensaje, nombreAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MensajeConfirmacion(string mensaje)
        {
            string nombreAplicacion = AplicacionHelper.ObtenerNombreDeAplicacion();
            MessageBox.Show(mensaje, nombreAplicacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
