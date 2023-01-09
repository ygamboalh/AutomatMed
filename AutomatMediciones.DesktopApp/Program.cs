using AutoMapper;
using AutomatMediciones.DesktopApp.Helpers;
using AutomatMediciones.DesktopApp.Pantallas;
using AutomatMediciones.DesktopApp.Pantallas.Celdas;
using AutomatMediciones.DesktopApp.Pantallas.CertificadosDeCalibracion;
using AutomatMediciones.DesktopApp.Pantallas.Clasificaciones;
using AutomatMediciones.DesktopApp.Pantallas.Ingresos;
using AutomatMediciones.DesktopApp.Pantallas.Instrumentos;
using AutomatMediciones.DesktopApp.Pantallas.Marcas;
using AutomatMediciones.DesktopApp.Pantallas.Modelos;
using AutomatMediciones.DesktopApp.Pantallas.Patrones;
using AutomatMediciones.DesktopApp.Pantallas.Principales;
using AutomatMediciones.DesktopApp.Pantallas.TiposDeInstrumento;
using AutomatMediciones.DesktopApp.Pantallas.Usuarios;
using AutomatMediciones.DesktopApp.Pantallas.VariablesDeMedicion;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Dominio.Common;
using AutomatMediciones.Dominio.Infraestructura;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace AutomatMediciones.DesktopApp
{
    static class Program
    {

        public static IServiceCollection services { get; set; }
        [STAThread]
        static void Main()
        {

            try
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                ConfigureServices();

                using (var serviceProvider = services.BuildServiceProvider())
                {
                    var frmPrincipal = serviceProvider.GetRequiredService<frmPrincipal>();
                    Application.Run(frmPrincipal);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private static void ConfigureServices()
        {
            services = new ServiceCollection();


            string tacticaConneccionString = AplicacionHelper.ObtenerCadenaConexion("TacticaConnectionString");
            string automatConnectionString = AplicacionHelper.ObtenerCadenaConexion("AutomatConnectionString");

            services.AddDbContext<TacticaDbContext>(options => options.UseMySql(tacticaConneccionString, ServerVersion.AutoDetect(tacticaConneccionString)));
            services.AddDbContext<AutomatMedicionesDbContext>(options => options.UseMySql(automatConnectionString, ServerVersion.AutoDetect(automatConnectionString)));

            services.AddAutoMapper(options => options.AddProfile(new ConfigMap()));

            services.AddTransient<UnidadMedidaService, UnidadMedidaService>();
            services.AddTransient<EmpresaService, EmpresaService>();
            services.AddTransient<EstadoService, EstadoService>();
            services.AddTransient<TipoTrabajoService, TipoTrabajoService>();
            services.AddTransient<IngresoService, IngresoService>();
            services.AddTransient<InstrumentoService, InstrumentoService>();
            services.AddTransient<TipoDeInstrumentoService, TipoDeInstrumentoService>();
            services.AddTransient<ModeloService, ModeloService>();
            services.AddTransient<MarcaService, MarcaService>();
            services.AddTransient<UsuarioService, UsuarioService>();
            services.AddTransient<ClasificacionInstrumentoService, ClasificacionInstrumentoService>();
            services.AddTransient<VariableMedicionService, VariableMedicionService>();
            services.AddTransient<ConfiguracionNotificacionService, ConfiguracionNotificacionService>();
            services.AddTransient<PatronService, PatronService>();
            services.AddTransient<CertificadoCalibracionService, CertificadoCalibracionService>();
            services.AddTransient<CeldaService, CeldaService>();
            services.AddTransient<ProductoService, ProductoService>();
            services.AddTransient<PresupuestoService, PresupuestoService>();
            services.AddTransient<MonedaService, MonedaService>();
            services.AddTransient<MenuService, MenuService>();

            services.AddScoped<frmPrincipal>();

            services.AddScoped<frmClasificaciones>();
            services.AddScoped<frmNuevaClasificacion>();

            services.AddScoped<frmIngresos>();

            services.AddScoped<frmMarcas>();
            services.AddScoped<frmNuevaMarca>();

            services.AddScoped<frmModelos>();
            services.AddScoped<frmNuevoModelo>();

            services.AddScoped<frmNuevoTipoInstrumento>();
            services.AddScoped<frmTiposDeInstrumento>();

            services.AddScoped<frmNuevaVariableMedicion>();
            services.AddScoped<frmVariablesDeMedicion>();

            services.AddScoped<frmUsuarios>();

            services.AddScoped<frmEmpresas>();
            services.AddScoped<frmNuevoIngreso>();

            services.AddScoped<frmInstrumentos>();
            services.AddScoped<frmNuevoInstrumento>();

            services.AddScoped<frmPatrones>();
            services.AddScoped<frmNuevoPatron>();

            services.AddScoped<frmCeldas>();

            services.AddScoped<frmNuevoCertificadoCalibracion>();
        }
    }
}
