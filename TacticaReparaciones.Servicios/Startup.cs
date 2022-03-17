using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Nagaira.Extensions.Configuration;
using TacticaReparaciones.Servicios.Caracteristicas.Servicios;
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
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TacticaReparaciones.Servicios", Version = "v1" });
            });

            services.AddDbContext<TacticaDbContext>(options => options.UseMySql(Configuration.GetConnectionStringFromENV("TacticaBD")).EnableDetailedErrors());
            services.AddDbContext<TacticaReparacionesDbContext>(options => options.UseMySql(Configuration.GetConnectionStringFromENV("TacticaReparacionesBD")).EnableDetailedErrors());

            services.AddTransient<EmpresaService, EmpresaService>();
            services.AddTransient<EstadoService, EstadoService>();
            services.AddTransient<TipoTrabajoService, TipoTrabajoService>();
            services.AddTransient<IngresoService, IngresoService>();
            services.AddTransient<InstrumentoService, InstrumentoService>();
            services.AddTransient<TipoDeInstrumentoService, TipoDeInstrumentoService>();
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
