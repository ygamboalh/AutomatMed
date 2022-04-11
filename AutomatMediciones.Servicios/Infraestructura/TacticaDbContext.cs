using Microsoft.EntityFrameworkCore;
using AutomatMediciones.Servicios.Caracteristicas.Entidades;
using AutomatMediciones.Servicios.Infraestructura.Maps;

namespace AutomatMediciones.Servicios.Infraestructura
{
    public class TacticaDbContext : DbContext
    {
        public TacticaDbContext(DbContextOptions<TacticaDbContext> options) : base(options)
        {

        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<CorreoElectronico> CorreosElectronicos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmpresaMap());
            modelBuilder.ApplyConfiguration(new CorreoElectronicoMap());
            modelBuilder.ApplyConfiguration(new ContactoMap());
            modelBuilder.ApplyConfiguration(new EstadoMap());
        }
    }
}
