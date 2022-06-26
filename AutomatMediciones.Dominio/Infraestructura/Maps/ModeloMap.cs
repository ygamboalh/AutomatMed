using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class ModeloMap : IEntityTypeConfiguration<Modelo>
    {
        public void Configure(EntityTypeBuilder<Modelo> builder)
        {
            builder.ToTable("modelos");

            builder.HasKey(x => x.ModeloId);
            builder.Property(x => x.ModeloId).HasColumnName("modelo_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Descripcion).HasColumnName("descripcion").HasColumnType("VARCHAR(200)").IsRequired();

            // builder.HasMany(x => x.TiposDeCeldaModelo).WithOne(x => x.Modelo).HasForeignKey(x => x.ModeloId);
        }
    }
}
