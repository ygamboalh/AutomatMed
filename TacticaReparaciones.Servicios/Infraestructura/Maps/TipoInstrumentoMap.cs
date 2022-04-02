using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TacticaReparaciones.Servicios.Caracteristicas.Entidades;

namespace TacticaReparaciones.Servicios.Infraestructura.Maps
{
    public class TipoInstrumentoMap : IEntityTypeConfiguration<TipoInstrumento>
    {
        public void Configure(EntityTypeBuilder<TipoInstrumento> builder)
        {
            builder.ToTable("tipos_de_instrumento");

            builder.HasKey(x => x.TipoInstrumentoId);
            builder.Property(x => x.TipoInstrumentoId).HasColumnName("tipo_instrumento_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Descripcion).HasColumnName("descripcion").HasColumnType("VARCHAR(200)").IsRequired();

            
        }
    }
}
