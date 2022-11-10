using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    internal class ProductoPrecioMap : IEntityTypeConfiguration<ProductoPrecio>
    {
        public void Configure(EntityTypeBuilder<ProductoPrecio> builder)
        {
            builder.ToTable("productosprecios");

            builder.HasKey(x => x.RecID);
            builder.Property(x => x.RecID).HasColumnName("RecID").HasColumnType("VARCHAR(12)");
            builder.Property(x => x.IDProducto).HasColumnName("IDProducto").HasColumnType("VARCHAR(12)");
            builder.Property(x => x.Precio).HasColumnName("Precio").HasColumnType("double");
            builder.Property(x => x.Costo).HasColumnName("Costo").HasColumnType("double");
            builder.Property(x => x.NroMonedaPrecio).HasColumnName("NroMonedaPrecio").HasColumnType("tinyint");
            builder.Property(x => x.NroLista).HasColumnName("NroLista").HasColumnType("tinyint");
        }
    }
}
