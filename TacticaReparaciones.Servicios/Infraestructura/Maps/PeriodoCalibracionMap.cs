using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TacticaReparaciones.Servicios.Caracteristicas.Entidades;

namespace TacticaReparaciones.Servicios.Infraestructura.Maps
{
    public class PeriodoCalibracionMap : IEntityTypeConfiguration<PeriodoDeCalibracion>
    {
        public void Configure(EntityTypeBuilder<PeriodoDeCalibracion> builder)
        {
            builder.ToTable("periodos_de_calibracion");

            builder.HasKey(x => x.PeriodoCalibracionId);
            builder.Property(x => x.PeriodoCalibracionId).HasColumnName("periodo_calibracion_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Descripcion).HasColumnName("descripcion").HasColumnType("VARCHAR(200)").IsRequired();
            builder.Property(x => x.TipoInstrumentoId).HasColumnName("tipo_instrumento_id").HasColumnType("INT").IsRequired();


            builder.HasOne(x => x.TipoInstrumento).WithMany(x => x.PeriodosDeCalibracion).HasForeignKey(x => x.TipoInstrumentoId);
            builder.HasMany(x => x.Instrumentos).WithOne(x => x.PeriodoDeCalibracion).HasForeignKey(x => x.PeriodoCalibracionId);

        }
    }
}
