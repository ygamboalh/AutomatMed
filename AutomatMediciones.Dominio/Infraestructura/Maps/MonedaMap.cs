using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class MonedaMap : IEntityTypeConfiguration<Moneda>
    {
        public void Configure(EntityTypeBuilder<Moneda> builder)
        {
            builder.ToTable("moneda");

            builder.HasKey(x => x.RecID);
            builder.Property(x => x.RecID).HasColumnName("RecID").HasColumnType("varchar(12)");
            builder.Property(x => x.Numero).HasColumnName("Numero").HasColumnType("tinyint");
            builder.Property(x => x.Descripcion).HasColumnName("Moneda").HasColumnType("varchar(50)");
            builder.Property(x => x.Simbolo).HasColumnName("Simbolo").HasColumnType("varchar(50)");
        }
    }
}
