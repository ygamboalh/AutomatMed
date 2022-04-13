using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class ClasificacionInstrumentoMap : IEntityTypeConfiguration<ClasificacionInstrumento>
    {
        public void Configure(EntityTypeBuilder<ClasificacionInstrumento> builder)
        {
            builder.ToTable("clasificaciones_instrumentos");

            builder.HasKey(x => x.ClasificacionId);
            builder.Property(x => x.ClasificacionId).HasColumnName("clasificacion_id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.TipoInstrumentoId).HasColumnName("tipo_instrumento_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.ModeloId).HasColumnName("modelo_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.MarcaId).HasColumnName("marca_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.PeriodoDeCalibracion).HasColumnName("periodo_calibracion").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Activo).HasColumnName("activo").HasColumnType("TINYINT").IsRequired();


        }
    }
}
