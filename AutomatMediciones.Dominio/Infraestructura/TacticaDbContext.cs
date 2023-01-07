using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using AutomatMediciones.Dominio.Infraestructura.Maps;
using Microsoft.EntityFrameworkCore;

namespace AutomatMediciones.Dominio.Infraestructura
{
    public class TacticaDbContext : DbContext
    {
        public TacticaDbContext(DbContextOptions<TacticaDbContext> options) : base(options) { }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<CorreoElectronico> CorreosElectronicos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Presupuesto> Presupuestos { get; set; }
        public DbSet<PresupuestoItem> PresupuestosItems { get; set; }
        public DbSet<ArbolCarpeta> ArbolCarpetas { get; set; }
        public DbSet<ProductoPrecio> ProductoPrecios { get; set; }
        public DbSet<Moneda> Monedas { get; set; }
        public DbSet<MonedaCotizacion> MonedasCotizaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("latin1_swedish_ci").ApplyConfiguration(new EmpresaMap());
            modelBuilder.UseCollation("latin1_swedish_ci").ApplyConfiguration(new CorreoElectronicoMap());
            modelBuilder.UseCollation("latin1_swedish_ci").ApplyConfiguration(new ContactoMap());
            modelBuilder.UseCollation("latin1_swedish_ci").ApplyConfiguration(new EstadoMap());
            modelBuilder.UseCollation("latin1_swedish_ci").ApplyConfiguration(new ProductoMap());
            modelBuilder.UseCollation("latin1_swedish_ci").ApplyConfiguration(new PresupuestoMap());
            modelBuilder.UseCollation("latin1_swedish_ci").ApplyConfiguration(new PresupuestoItemMap());
            modelBuilder.UseCollation("latin1_swedish_ci").ApplyConfiguration(new ArbolCarpetaMap());
            modelBuilder.UseCollation("latin1_swedish_ci").ApplyConfiguration(new MonedaMap());
            modelBuilder.UseCollation("latin1_swedish_ci").ApplyConfiguration(new ProductoPrecioMap());
            modelBuilder.UseCollation("latin1_swedish_ci").ApplyConfiguration(new MonedaCotizacionMap());
        }
    }
}
