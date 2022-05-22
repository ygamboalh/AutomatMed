using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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