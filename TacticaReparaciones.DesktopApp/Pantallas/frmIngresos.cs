namespace TacticaReparaciones.DesktopApp.Pantallas
{
    public partial class frmIngresos : DevExpress.XtraEditors.XtraForm
    {
        public frmIngresos()
        {
            InitializeComponent();
            EstablecerNombreYTituloDePantalla();
        }

        private void EstablecerNombreYTituloDePantalla()
        {
            string titulo = "Ingresos";
            this.Text = titulo;
            this.ctlEncabezadoPantalla1.lblTitulo.Text = titulo;
            this.ctlEncabezadoPantalla1.EstablecerColoresDeFondoYLetra();
        }

        private void iconButton1_MouseHover(object sender, System.EventArgs e)
        {
            toolTip1.SetToolTip(btnBuscarEmpresa, "Presione para ir la a pantalla que le permite buscar y seleccionar una empresa");
        }

        private void btnBuscarEmpresa_Click(object sender, System.EventArgs e)
        {

        }
    }
}