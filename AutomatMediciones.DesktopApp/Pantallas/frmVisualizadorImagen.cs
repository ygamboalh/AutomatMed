using System.Drawing;

namespace AutomatMediciones.DesktopApp.Pantallas
{
    public partial class frmVisualizadorImagen : DevExpress.XtraEditors.XtraForm
    {
        public frmVisualizadorImagen(string rutaImagen)
        {
            InitializeComponent();
            imageSlider1.Images.Add(Image.FromFile(rutaImagen));
        }
    }
}