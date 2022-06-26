using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class EstadoCeldaMap : IEntityTypeConfiguration<EstadoCelda>
    {
        public void Configure(EntityTypeBuilder<EstadoCelda> builder)
        {
            builder.ToTable("estados_celda");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.Descripcion).HasColumnName("descripcion").HasColumnType("VARCHAR(50)").IsRequired();

        }
    }
}
