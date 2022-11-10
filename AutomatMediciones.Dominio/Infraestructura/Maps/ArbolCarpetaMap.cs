using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class ArbolCarpetaMap : IEntityTypeConfiguration<ArbolCarpeta>
    {
        public void Configure(EntityTypeBuilder<ArbolCarpeta> builder)
        {
            builder.ToTable("arbolcarpetas");

            builder.HasKey(x => x.RecId);
            builder.Property(x => x.RecId).HasColumnName("RecID").HasColumnType("VARCHAR(12)");
            builder.Property(x => x.Nombre).HasColumnName("Nombre").HasColumnType("varchar(255)");
            builder.Property(x => x.Tipo).HasColumnName("Tipo").HasColumnType("tinyint");
            builder.Property(x => x.Orden).HasColumnName("Orden").HasColumnType("int");
            builder.Property(x => x.Nivel).HasColumnName("Nivel").HasColumnType("int");
            builder.Property(x => x.IdRef).HasColumnName("IdRef").HasColumnType("varchar(12)");
            builder.Property(x => x.IdPadre).HasColumnName("IdPadre").HasColumnType("varchar(12)");
        }
    }
}
