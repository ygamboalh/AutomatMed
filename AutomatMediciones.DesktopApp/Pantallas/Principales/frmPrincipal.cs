using AutomatMediciones.DesktopApp.Enums;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.Diagnosticos;
using AutomatMediciones.DesktopApp.Pantallas.Ingresos;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Principales
{
    public partial class frmPrincipal : DevExpress.XtraEditors.XtraForm
    {
        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();

        public frmPrincipal()
        {
            InitializeComponent();
            this.cmpMenu1.OnMenuSeleccionado += cmpMenuOnMenuSeleccionado;

            EstablecerNombreAplicacion();
            EstablecerFondoMdiPantalla();
            EstablecerEtiquetaVersionAplicacion();
            EstablecerEtiquetaNombreServidorBaseDatos();
            EstablecerColorFondoBarraEstado();

            this.cmpMenu1.InicializarControl();
        }

        private void EstablecerColorFondoBarraEstado()
        {
            this.pnlStatus.BackColor = ColorHelper.ObtenerColorEnRGB("Primary200");
        }

        private void EstablecerNombreAplicacion()
        {
            this.Text = AplicacionHelper.ObtenerNombreDeAplicacion();
        }

        private void EstablecerEtiquetaVersionAplicacion()
        {
            lblVersion.Text = $"{this.Text} | V{Application.ProductVersion}";
        }

        private void EstablecerEtiquetaNombreServidorBaseDatos()
        {

            lblBaseDatos.Text = AplicacionHelper.ObtenerDataBaseServer("AutomatConnectionString");
        }

        private void cmpMenuOnMenuSeleccionado(IndiceMenu indiceMenu)
        {
            switch (indiceMenu)
            {
                case IndiceMenu.Ingresos:
                    SplashScreenManager.ShowForm(typeof(frmSaving));
                    var frmIngresos = new frmIngresos(serviceProvider.GetService<IngresoService>(),
                                                       serviceProvider.GetService<InstrumentoService>(),
                                                       serviceProvider.GetService<UsuarioService>(),
                                                       serviceProvider.GetService<ConfiguracionNotificacionService>()
                                                      );
                    XtraForm ingresos = frmIngresos;
                    AgregarPantalla(ref ingresos);
                    SplashScreenManager.CloseForm();
                    break;
                case IndiceMenu.Diagnosticos:
                    SplashScreenManager.ShowForm(typeof(frmSaving));
                    var frmDiagnosticos = new frmDiagnosticos(serviceProvider.GetService<IngresoService>());
                    XtraForm diagnosticos = frmDiagnosticos;
                    AgregarPantalla(ref diagnosticos);
                    SplashScreenManager.CloseForm();
                    break;
                case IndiceMenu.Configuracion:
                    SplashScreenManager.ShowForm(typeof(frmSaving));
                    var frmConfiguracion = new frmConfiguracion();
                    XtraForm configuraciones = frmConfiguracion;
                    AgregarPantalla(ref configuraciones);
                    SplashScreenManager.CloseForm();
                    break;
            }
        }

        private void AgregarPantalla(ref XtraForm pantalla)
        {
            if (pantalla.Created)
            {
                pantalla.Focus();
            }
            else
            {
                pantalla.MdiParent = this;
                pantalla.Show();
            }
        }

        private void EstablecerFondoMdiPantalla()
        {
            MdiClient pantallaMDI;
            foreach (Control iterador in this.Controls)
            {
                var type = iterador.GetType();
                if (type.Name == "MdiClient")
                {
                    pantallaMDI = (MdiClient)iterador;
                    pantallaMDI.BackColor = Color.White;
                }
            }
        }
    }
}
