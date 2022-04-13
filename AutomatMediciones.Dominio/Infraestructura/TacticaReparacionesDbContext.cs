using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using AutomatMediciones.Dominio.Infraestructura.Maps;
using Microsoft.EntityFrameworkCore;

namespace AutomatMediciones.Dominio.Infraestructura
{
    public class AutomatMedicionesDbContext : DbContext
    {
        public AutomatMedicionesDbContext(DbContextOptions<AutomatMedicionesDbContext> options) : base(options) { }

        public DbSet<Certificado> Certificados { get; set; }
        public DbSet<ClasificacionInstrumento> ClasificacionesInstrumentos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Ingreso> Ingresos { get; set; }
        public DbSet<IngresoInstrumento> IngresosInstrumentos { get; set; }
        public DbSet<Instrumento> Instrumentos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<OrdenTrabajo> OrdenesDeTrabajo { get; set; }
        public DbSet<Patron> Patrones { get; set; }
        public DbSet<TipoOrdenTrabajo> TiposOrdenTrabajo { get; set; }
        public DbSet<TipoInstrumento> TiposDeInstrumentos { get; set; }
        public DbSet<TipoInstrumentoVariable> TiposDeInstrumentosVariable { get; set; }
        public DbSet<TipoTrabajo> TiposDeTrabajo { get; set; }
        public DbSet<VariableCertificado> VariablesCertificados { get; set; }
        public DbSet<VariableDeMedicion> VariablesDeMedicion { get; set; }
        public DbSet<VariableInstrumento> VariablesInstrumentos { get; set; }
        public DbSet<VariablePatron> VariablesPatrones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CertificadoMap());

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
            modelBuilder.ApplyConfiguration(new TipoInstrumentoVariableMap());
            modelBuilder.ApplyConfiguration(new VariableInstrumentoMap());
            modelBuilder.ApplyConfiguration(new VariableCertificadoMap());
            modelBuilder.ApplyConfiguration(new TipoOrdenTrabajoMap());
            modelBuilder.ApplyConfiguration(new PatronMap());
            modelBuilder.ApplyConfiguration(new OrdenTrabajoMap());

            modelBuilder.ApplyConfiguration(new VariablePatronMap());
        }
    }
}
