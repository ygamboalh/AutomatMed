using System.Drawing;
using System.Windows.Forms;
using TacticaReparaciones.DesktopApp.Helpers;

namespace TacticaReparaciones.DesktopApp.Componentes.Menu
{
    public partial class cmpMenu : UserControl
    {       
        public cmpMenu()
        {
            InitializeComponent();
            
        }

        bool expandirMenu;
        public bool ExpandirMenu
        {
            get
            {             
                return expandirMenu;
            }
            set
            {
                expandirMenu = value;
                AccionarTamanioMenu();
            }
        }

        public void InicializarControl()
        {
            this.BackColor = ColorHelper.ObtenerColorEnRGB("Primary200");
            cmdIngresos.BackColor = ColorHelper.ObtenerColorEnRGB("Primary300");
            ExpandirMenu = true;

            cmpLogo1.InicializarControl();
        }

        private void btnExpandirMenu_Click(object sender, System.EventArgs e)
        {
            ExpandirMenu = !ExpandirMenu;
        }

        private void AccionarTamanioMenu ()
        {
            var ancho = ExpandirMenu ? { this.MaximumSize.Width this.pnlMenuExpandido.Visible =} : this.btnExpandirMenu.Width;
            this.Size = new Size(ancho, this.Height);

        }

        private void cmdIngresos_Click(object sender, System.EventArgs e)
        {

        }
    }
}
