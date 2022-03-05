using Microsoft.EntityFrameworkCore;
using TacticaReparaciones.Servicios.Caracteristicas.Entidades;
using TacticaReparaciones.Servicios.Infraestructura.Maps;

namespace TacticaReparaciones.Servicios.Infraestructura
{
    public class TacticaReparacionesDbContext : DbContext
    {
        public TacticaReparacionesDbContext(DbContextOptions<TacticaReparacionesDbContext> options) : base(options)
        {

        }

        public DbSet<Estado> Estados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new EstadoMap());
        }
    }
}
