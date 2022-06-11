namespace AutomatMediciones.DesktopApp.Pantallas
{
    public partial class frmVisualizadorPdf : DevExpress.XtraEditors.XtraForm
    {
        public frmVisualizadorPdf(string rutaArchivo)
        {
            InitializeComponent();
            pdfViewer1.LoadDocument(rutaArchivo);
        }
    }
}