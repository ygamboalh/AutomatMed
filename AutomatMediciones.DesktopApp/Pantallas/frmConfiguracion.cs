using AutomatMediciones.DesktopApp.Pantallas.CertificadosDeCalibracion;
using AutomatMediciones.DesktopApp.Pantallas.Clasificaciones;
using AutomatMediciones.DesktopApp.Pantallas.Instrumentos;
using AutomatMediciones.DesktopApp.Pantallas.Marcas;
using AutomatMediciones.DesktopApp.Pantallas.Modelos;
using AutomatMediciones.DesktopApp.Pantallas.Patrones;
using AutomatMediciones.DesktopApp.Pantallas.TiposDeInstrumento;
using AutomatMediciones.DesktopApp.Pantallas.VariablesDeMedicion;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AutomatMediciones.DesktopApp.Pantallas
{
    public partial class frmConfiguracion : DevExpress.XtraEditors.XtraForm
    {
        private ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void tipoInstrumentoMenu_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            serviceProvider = Program.services.BuildServiceProvider();
            var frmTipoInstrumento = new frmTiposDeInstrumento(serviceProvider.GetService<TipoDeInstrumentoService>());
            XtraForm tiposDeInstrumento = frmTipoInstrumento;
            AgregarPantalla(ref tiposDeInstrumento);
            SplashScreenManager.CloseForm();
        }

        private void AgregarPantalla(ref XtraForm pantalla)
        {
            if (pantalla.Created)
            {
                pantalla.Focus();
            }
            else
            {
                pantalla.MdiParent = this.ParentForm;
                pantalla.Show();
            }
        }

        private void marcaMenu_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            serviceProvider = Program.services.BuildServiceProvider();
            var frmMarcas = new frmMarcas(serviceProvider.GetService<MarcaService>());
            XtraForm marcas = frmMarcas;
            AgregarPantalla(ref marcas);
            SplashScreenManager.CloseForm();
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            serviceProvider = Program.services.BuildServiceProvider();
            var frmModelos = new frmModelos(serviceProvider.GetService<ModeloService>());
            XtraForm modelos = frmModelos;
            AgregarPantalla(ref modelos);
            SplashScreenManager.CloseForm();
        }

        private void clasificacionInstrumentoMenu_Click(object sender, EventArgs e)
        {
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
        }

        private void instrumentosMenu_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            serviceProvider = Program.services.BuildServiceProvider();
            var frmInstrumentos = new frmInstrumentos(serviceProvider.GetService<InstrumentoService>());
            XtraForm nuevoInstrumento = frmInstrumentos;
            AgregarPantalla(ref nuevoInstrumento);
            SplashScreenManager.CloseForm();
        }

        private void variableMedicionMenu_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            serviceProvider = Program.services.BuildServiceProvider();
            var frmVariablesDeMedicion = new frmVariablesDeMedicion(serviceProvider.GetService<VariableMedicionService>());
            XtraForm variablesMedicion = frmVariablesDeMedicion;
            AgregarPantalla(ref variablesMedicion);
            SplashScreenManager.CloseForm();
        }

        private void patronesMenu_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            serviceProvider = Program.services.BuildServiceProvider();
            var frmPatrones = new frmPatrones(serviceProvider.GetService<PatronService>());
            XtraForm patrones = frmPatrones;
            AgregarPantalla(ref patrones);
            SplashScreenManager.CloseForm();
        }

        private void certificadosPatrones_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmSaving));
            serviceProvider = Program.services.BuildServiceProvider();
            var frmCertificados = new frmCertificadosDeCalibracion(serviceProvider.GetService<CertificadoCalibracionService>());
            XtraForm patrones = frmCertificados;
            AgregarPantalla(ref patrones);
            SplashScreenManager.CloseForm();

        }
    }
}