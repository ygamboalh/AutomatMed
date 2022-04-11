using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using AutomatMediciones.DesktopApp.Helpers;

namespace AutomatMediciones.DesktopApp.Componentes.Menu
{
    public partial class cmpLogo : UserControl
    {
        public cmpLogo()
        {
            InitializeComponent();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath raizDeGraficos = new GraphicsPath();
            raizDeGraficos.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(raizDeGraficos);
            base.OnPaint(e);
        }

        public void InicializarControl()
        {
            this.BackColor = ColorHelper.ObtenerColorEnRGB("Primary500");
        }
    }
}
