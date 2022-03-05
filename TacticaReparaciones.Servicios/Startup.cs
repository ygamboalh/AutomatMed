using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
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

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<TacticaDbContext>(options => options.UseMySql(Configuration.GetConnectionString("TacticaBD"),
                                                                                ServerVersion.AutoDetect(Configuration.GetConnectionString("TacticaBD"))
                                                                                )
            );

            services.AddDbContext<TacticaReparacionesDbContext>(options => options.UseMySql(Configuration.GetConnectionString("TacticaReparacionesBD"),
                                                                              ServerVersion.AutoDetect(Configuration.GetConnectionString("TacticaReparacionesBD"))
                                                                              )
          );

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TacticaReparaciones.Servicios", Version = "v1" });
            });

            services.AddTransient<EmpresaService, EmpresaService>();
            services.AddTransient<EstadoService, EstadoService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
