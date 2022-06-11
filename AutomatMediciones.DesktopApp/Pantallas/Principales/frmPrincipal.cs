using AutomatMediciones.DesktopApp.Enums;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas.CertificadosDeCalibracion;
using AutomatMediciones.DesktopApp.Pantallas.Ingresos;
using AutomatMediciones.DesktopApp.Pantallas.Instrumentos;
using AutomatMediciones.DesktopApp.Pantallas.Marcas;
using AutomatMediciones.DesktopApp.Pantallas.Modelos;
using AutomatMediciones.DesktopApp.Pantallas.Patrones;
using AutomatMediciones.DesktopApp.Pantallas.TiposDeInstrumento;
using AutomatMediciones.DesktopApp.Pantallas.VariablesDeMedicion;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using DevExpress.XtraEditors;
using AutomatMediciones.DesktopApp.Pantallas.Clasificaciones;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp.Pantallas.Principales
{
    public partial class frmPrincipal : DevExpress.XtraEditors.XtraForm
    {
        private ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        private bool mostrarBotonesConfiguracion = false;

        public frmPrincipal()
        {
            InitializeComponent();
            this.cmpMenu1.OnMenuSeleccionado += cmpMenuOnMenuSeleccionado;

            EstablecerNombreAplicacion();
            EstablecerFondoMdiPantalla();
            EstablecerEtiquetaVersionAplicacion();
            EstablecerEtiquetaNombreServidorBaseDatos();
            EstablecerColorFondoBarraEstado();

            this.cmpMenu1.AccionesBotonConfiguracion(mostrarBotonesConfiguracion);
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
            serviceProvider = Program.services.BuildServiceProvider();
            switch (indiceMenu)
            {
                case IndiceMenu.Ingresos:
                    SplashScreenManager.ShowForm(typeof(frmSaving));
                    var frmIngresos = new frmNuevoIngreso(serviceProvider.GetService<IngresoService>(),
                                                       serviceProvider.GetService<InstrumentoService>(),
                                                       serviceProvider.GetService<UsuarioService>(),
                                                       serviceProvider.GetService<ConfiguracionNotificacionService>(),
                                                       serviceProvider.GetService<EstadoService>()
                                                      );
                    XtraForm ingresos = frmIngresos;
                    AgregarPantalla(ref ingresos);
                    SplashScreenManager.CloseForm();
                    break;
                case IndiceMenu.Diagnosticos:
                    SplashScreenManager.ShowForm(typeof(frmSaving));
                    var frmDiagnosticos = new frmIngresos(serviceProvider.GetService<IngresoService>());
                    XtraForm diagnosticos = frmDiagnosticos;
                    AgregarPantalla(ref diagnosticos);
                    SplashScreenManager.CloseForm();
                    break;
                case IndiceMenu.Configuracion:
                    mostrarBotonesConfiguracion = !mostrarBotonesConfiguracion;
                    cmpMenu1.AccionesBotonConfiguracion(mostrarBotonesConfiguracion);
                    break;
                case IndiceMenu.Certificados:
                    SplashScreenManager.ShowForm(typeof(frmSaving));
                    serviceProvider = Program.services.BuildServiceProvider();
                    var frmCertificados = new frmCertificadosDeCalibracion(serviceProvider.GetService<CertificadoCalibracionService>());
                    XtraForm certificados = frmCertificados;
                    AgregarPantalla(ref certificados);
                    SplashScreenManager.CloseForm();
                    break;
                case IndiceMenu.Clasificaciones:
                    SplashScreenManager.ShowForm(typeof(frmSaving));
                    serviceProvider = Program.services.BuildServiceProvider();
                    var frmClasificaciones = new frmClasificaciones(serviceProvider.GetService<ClasificacionInstrumentoService>(),
                                                                    serviceProvider.GetService<MarcaService>(),
                                                                    serviceProvider.GetService<ModeloService>(),
                                                                    serviceProvider.GetService<TipoDeInstrumentoService>()
                                                                    );
                    XtraForm clasificaciones = frmClasificaciones;
                    AgregarPantalla(ref clasificaciones);
                    SplashScreenManager.CloseForm();
                    break;
                case IndiceMenu.Marcas:
                    SplashScreenManager.ShowForm(typeof(frmSaving));
                    serviceProvider = Program.services.BuildServiceProvider();
                    var frmMarcas = new frmMarcas(serviceProvider.GetService<MarcaService>());
                    XtraForm marcas = frmMarcas;
                    AgregarPantalla(ref marcas);
                    SplashScreenManager.CloseForm();
                    break;
                case IndiceMenu.Modelos:
                    SplashScreenManager.ShowForm(typeof(frmSaving));
                    serviceProvider = Program.services.BuildServiceProvider();
                    var frmModelos = new frmModelos(serviceProvider.GetService<ModeloService>());
                    XtraForm modelos = frmModelos;
                    AgregarPantalla(ref modelos);
                    SplashScreenManager.CloseForm();
                    break;
                case IndiceMenu.TiposInstrumentos:
                    SplashScreenManager.ShowForm(typeof(frmSaving));
                    serviceProvider = Program.services.BuildServiceProvider();
                    var frmTipoInstrumento = new frmTiposDeInstrumento(serviceProvider.GetService<TipoDeInstrumentoService>());
                    XtraForm tiposDeInstrumento = frmTipoInstrumento;
                    AgregarPantalla(ref tiposDeInstrumento);
                    SplashScreenManager.CloseForm();
                    break;
                case IndiceMenu.VariablesMedicion:
                    SplashScreenManager.ShowForm(typeof(frmSaving));
                    serviceProvider = Program.services.BuildServiceProvider();
                    var frmVariablesDeMedicion = new frmVariablesDeMedicion(serviceProvider.GetService<VariableMedicionService>());
                    XtraForm variablesMedicion = frmVariablesDeMedicion;
                    AgregarPantalla(ref variablesMedicion);
                    SplashScreenManager.CloseForm();
                    break;
                case IndiceMenu.Patrones:
                    SplashScreenManager.ShowForm(typeof(frmSaving));
                    serviceProvider = Program.services.BuildServiceProvider();
                    var frmPatrones = new frmPatrones(serviceProvider.GetService<PatronService>());
                    XtraForm patrones = frmPatrones;
                    AgregarPantalla(ref patrones);
                    SplashScreenManager.CloseForm();
                    break;
                case IndiceMenu.Instrumentos:
                    SplashScreenManager.ShowForm(typeof(frmSaving));
                    serviceProvider = Program.services.BuildServiceProvider();
                    var frmInstrumentos = new frmInstrumentos(serviceProvider.GetService<InstrumentoService>());
                    XtraForm nuevoInstrumento = frmInstrumentos;
                    AgregarPantalla(ref nuevoInstrumento);
                    SplashScreenManager.CloseForm();
                    break;
            }
        }

        private void AgregarPantalla(ref XtraForm pantalla)
        {
            if (!pantalla.Created)
            {
                pantalla.MdiParent = this;
                pantalla.Show();
            }

            //if (pantalla.Created)
            //{
            //    pantalla.Focus();
            //}
            //else
            //{
            //    pantalla.MdiParent = this;
            //    pantalla.Show();
            //}
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
