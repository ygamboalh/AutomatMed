using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class ProductoMap : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("productos");

            builder.HasKey(x => x.RecID);
            builder.Property(x => x.RecID).HasColumnName("RecID").HasColumnType("VARCHAR(12)").IsRequired();
            builder.Property(x => x.SubFamilia).HasColumnName("SubFamilia").HasColumnType("VARCHAR(255)");
            builder.Property(x => x.Descripcion).HasColumnName("Descripcion").HasColumnType("MEDIUMTEXT");
            builder.Property(x => x.Fabricante).HasColumnName("Fabricante").HasColumnType("VARCHAR(255)");
            builder.Property(x => x.TipoProducto).HasColumnName("TipoProducto").HasColumnType("VARCHAR(255)");
            builder.Property(x => x.Imagen).HasColumnName("Imagen").HasColumnType("MEDIUMTEXT");
            builder.Property(x => x.Nombre).HasColumnName("Nombre").HasColumnType("VARCHAR(255)");
            builder.Property(x => x.Codigo).HasColumnName("Codigo").HasColumnType("VARCHAR(255)");
            builder.Property(x => x.Estado).HasColumnName("Estado").HasColumnType("INT");
            builder.Property(x => x.CodUnidad).HasColumnName("CodUnidad").HasColumnType("TINYINT");
            builder.Property(x => x.IdCarpeta).HasColumnName("IdCarpeta").HasColumnType("VARCHAR(12)");
        }
    }
}
