using AutomatMediciones.DesktopApp.Pantallas.Clasificaciones;
using AutomatMediciones.DesktopApp.Pantallas.Marcas;
using AutomatMediciones.DesktopApp.Pantallas.Modelos;
using AutomatMediciones.DesktopApp.Pantallas.TiposDeInstrumento;
using AutomatMediciones.DesktopApp.Pantallas.VariablesDeMedicion;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AutomatMediciones.DesktopApp.Pantallas
{
    public partial class frmConfiguracion : DevExpress.XtraEditors.XtraForm
    {
        private readonly ServiceProvider serviceProvider = Program.services.BuildServiceProvider();
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void tipoInstrumentoMenu_Click(object sender, EventArgs e)
        {
            var frmTipoInstrumento = new frmTiposDeInstrumento(serviceProvider.GetService<TipoDeInstrumentoService>());
            XtraForm tiposDeInstrumento = frmTipoInstrumento;
            AgregarPantalla(ref tiposDeInstrumento);
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

            var frmMarcas = new frmMarcas(serviceProvider.GetService<MarcaService>()) ;
            XtraForm marcas = frmMarcas;
            AgregarPantalla(ref marcas);
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            var frmModelos = new frmModelos(serviceProvider.GetService<ModeloService>());
            XtraForm modelos = frmModelos;
            AgregarPantalla(ref modelos);
        }

        private void clasificacionInstrumentoMenu_Click(object sender, EventArgs e)
        {
            var frmClasificaciones = new frmClasificaciones(serviceProvider.GetService<ClasificacionInstrumentoService>(),
                                                            serviceProvider.GetService<MarcaService>(),
                                                            serviceProvider.GetService<ModeloService>(),
                                                            serviceProvider.GetService<TipoDeInstrumentoService>()
                                                            );
            XtraForm clasificaciones = frmClasificaciones;
            AgregarPantalla(ref clasificaciones);
        }

        private void instrumentosMenu_Click(object sender, EventArgs e)
        {

            var frmNuevoInstrumento = new frmNuevoInstrumento(serviceProvider.GetService<ClasificacionInstrumentoService>(), serviceProvider.GetService<InstrumentoService>());
            XtraForm nuevoInstrumento = frmNuevoInstrumento;
            AgregarPantalla(ref nuevoInstrumento);
        }

        private void variableMedicionMenu_Click(object sender, EventArgs e)
        {
            var frmVariablesDeMedicion = new frmVariablesDeMedicion(serviceProvider.GetService<VariableMedicionService>());
            XtraForm variablesMedicion = frmVariablesDeMedicion;
            AgregarPantalla(ref variablesMedicion);
        }
    }
}