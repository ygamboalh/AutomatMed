using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TacticaReparaciones.Servicios.Caracteristicas.Entidades;

namespace TacticaReparaciones.Servicios.Infraestructura.Maps
{
    public class GarantiaMap : IEntityTypeConfiguration<Garantia>
    {
        public void Configure(EntityTypeBuilder<Garantia> builder)
        {
            builder.ToTable("garantias");

            builder.HasKey(x => x.GarantiaId);
            builder.Property(x => x.GarantiaId).HasColumnName("garantia_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Descripcion).HasColumnName("descripcion").HasColumnType("VARCHAR(200)").IsRequired();
            builder.Property(x => x.TipoInstrumentoId).HasColumnName("tipo_instrumento_id").HasColumnType("INT").IsRequired();

            builder.HasMany(x => x.Instrumentos).WithOne(x => x.Garantia).HasForeignKey(x => x.GarantiaId);
            builder.HasOne(x => x.TipoInstrumento).WithMany(x => x.Garantias).HasForeignKey(x => x.GarantiaId);
        }
    }
}
