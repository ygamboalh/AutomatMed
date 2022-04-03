using Microsoft.EntityFrameworkCore;
using TacticaReparaciones.Servicios.Caracteristicas.Entidades;
using TacticaReparaciones.Servicios.Infraestructura.Maps;

namespace TacticaReparaciones.Servicios.Infraestructura
{
    public class TacticaReparacionesDbContext : DbContext
    {
        public TacticaReparacionesDbContext(DbContextOptions<TacticaReparacionesDbContext> options) : base(options) { }

        public DbSet<Estado> Estados { get; set; }
        public DbSet<TipoTrabajo> TiposDeTrabajo { get; set; }
        public DbSet<Ingreso> Ingresos { get; set; }
        public DbSet<Instrumento> Instrumentos { get; set; }
        public DbSet<TipoInstrumento> TiposDeInstrumentos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<IngresoInstrumento> IngresosInstrumentos { get; set; }
        public DbSet<ClasificacionInstrumento> ClasificacionesInstrumentos { get; set; }
        public DbSet<VariableDeMedicion> VariablesDeMedicion { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new EstadoMap());
            modelBuilder.ApplyConfiguration(new TipoTrabajoMap());
            modelBuilder.ApplyConfiguration(new IngresoMap());
            modelBuilder.ApplyConfiguration(new InstrumentoMap());
            modelBuilder.ApplyConfiguration(new TipoInstrumentoMap());
            modelBuilder.ApplyConfiguration(new MarcaMap());
            modelBuilder.ApplyConfiguration(new ModeloMap());
            modelBuilder.ApplyConfiguration(new IngresoInstrumentoMap());
            modelBuilder.ApplyConfiguration(new ClasificacionInstrumentoMap());
            modelBuilder.ApplyConfiguration(new VariableDeMedicionMap());
        }
    }
}
