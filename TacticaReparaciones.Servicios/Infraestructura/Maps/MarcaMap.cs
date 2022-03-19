using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TacticaReparaciones.Servicios.Caracteristicas.Entidades;

namespace TacticaReparaciones.Servicios.Infraestructura.Maps
{
    public class MarcaMap : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.ToTable("marcas");

            builder.HasKey(x => x.MarcaId);
            builder.Property(x => x.MarcaId).HasColumnName("marca_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Descripcion).HasColumnName("descripcion").HasColumnType("VARCHAR(200)").IsRequired();
            builder.Property(x => x.TipoInstrumentoId).HasColumnName("tipo_instrumento_id").HasColumnType("INT").IsRequired();

            builder.HasMany(x => x.Instrumentos).WithOne(x => x.Marca).HasForeignKey(x => x.MarcaId);
            builder.HasMany(x => x.Modelos).WithOne(x => x.Marca).HasForeignKey(x => x.MarcaId);
            builder.HasOne(x => x.TipoInstrumento).WithMany(x => x.Marcas).HasForeignKey(x => x.TipoInstrumentoId);
        }
    }
}
