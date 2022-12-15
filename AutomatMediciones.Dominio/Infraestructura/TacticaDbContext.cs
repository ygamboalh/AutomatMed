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
            modelBuilder.ApplyConfiguration(new EmpresaMap());
            modelBuilder.ApplyConfiguration(new CorreoElectronicoMap());
            modelBuilder.ApplyConfiguration(new ContactoMap());
            modelBuilder.ApplyConfiguration(new EstadoMap());
            modelBuilder.ApplyConfiguration(new ProductoMap());
            modelBuilder.ApplyConfiguration(new PresupuestoMap());
            modelBuilder.ApplyConfiguration(new PresupuestoItemMap());
            modelBuilder.ApplyConfiguration(new ArbolCarpetaMap());
            modelBuilder.ApplyConfiguration(new MonedaMap());
            modelBuilder.ApplyConfiguration(new ProductoPrecioMap());
            modelBuilder.ApplyConfiguration(new MonedaCotizacionMap());
        }
    }
}
