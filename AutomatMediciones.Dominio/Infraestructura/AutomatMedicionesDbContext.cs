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
        public DbSet<Patron> Patrones { get; set; }
        public DbSet<TipoInstrumento> TiposDeInstrumentos { get; set; }
        public DbSet<TipoInstrumentoVariable> TiposDeInstrumentosVariable { get; set; }
        public DbSet<TipoTrabajo> TiposDeTrabajo { get; set; }
        public DbSet<VariableCertificado> VariablesCertificados { get; set; }
        public DbSet<VariableDeMedicion> VariablesDeMedicion { get; set; }
        public DbSet<VariableInstrumento> VariablesInstrumentos { get; set; }
        public DbSet<VariablePatron> VariablesPatrones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ConfiguracionNotificacion> ConfiguracionesNotificaciones { get; set; }
        public DbSet<TipoCelda> TiposDeCeldas { get; set; }
        public DbSet<TipoCeldaModelo> TiposDeCeldasModelos { get; set; }
        public DbSet<Celda> Celdas { get; set; }
        public DbSet<CeldaInstrumento> CeldasInstrumentos { get; set; }
        public DbSet<EstadoCelda> EstadosCeldas { get; set; }
        public DbSet<UnidadMedida> UnidadesDeMedida { get; set; }
        public DbSet<ProductoPrecio> ProductoPrecios { get; set; }


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
            modelBuilder.ApplyConfiguration(new PatronMap());
            modelBuilder.ApplyConfiguration(new VariablePatronMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new ConfiguracionNotificacionMap());
            modelBuilder.ApplyConfiguration(new TipoCeldaMap());
            modelBuilder.ApplyConfiguration(new TipoCeldaModeloMap());
            modelBuilder.ApplyConfiguration(new CeldaMap());
            modelBuilder.ApplyConfiguration(new CeldaInstrumentoMap());
            modelBuilder.ApplyConfiguration(new EstadoCeldaMap());
            modelBuilder.ApplyConfiguration(new UnidadMedidaMap());
            modelBuilder.ApplyConfiguration(new ProductoPrecioMap());
        }
    }
}
