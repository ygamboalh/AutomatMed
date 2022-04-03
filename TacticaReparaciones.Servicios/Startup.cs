using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Nagaira.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using TacticaReparaciones.Servicios.Caracteristicas.Servicios;
using TacticaReparaciones.Servicios.Common;
using TacticaReparaciones.Servicios.Infraestructura;


namespace TacticaReparaciones.Servicios
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                options.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Local;
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TacticaReparaciones.Servicios", Version = "v1" });
            });

            services.AddAutoMapper(options => options.AddProfile(new ConfigMap()));

            services.AddDbContext<TacticaDbContext>(options => options.UseMySql(Configuration.GetConnectionStringFromENV("TacticaBD")).EnableDetailedErrors());
            services.AddDbContext<TacticaReparacionesDbContext>(options => options.UseMySql(Configuration.GetConnectionStringFromENV("TacticaReparacionesBD")).EnableDetailedErrors());

            services.AddTransient<EmpresaService, EmpresaService>();
            services.AddTransient<EstadoService, EstadoService>();
            services.AddTransient<TipoTrabajoService, TipoTrabajoService>();
            services.AddTransient<IngresoService, IngresoService>();
            services.AddTransient<InstrumentoService, InstrumentoService>();
            services.AddTransient<TipoDeInstrumentoService, TipoDeInstrumentoService>();
            services.AddTransient<ModeloService, ModeloService>();
            services.AddTransient<MarcaService, MarcaService>();
            services.AddTransient<ClasificacionInstrumentoService, ClasificacionInstrumentoService>();
            services.AddTransient<VariableMedicionService, VariableMedicionService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TacticaReparaciones.Servicios v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
