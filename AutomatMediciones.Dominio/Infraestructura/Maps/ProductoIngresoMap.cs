using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class ProductoIngresoMap : IEntityTypeConfiguration<ProductoIngreso>
    {
        public void Configure(EntityTypeBuilder<ProductoIngreso> builder)
        {
            builder.ToTable("productos_ingresos");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.ProductoId).HasColumnName("producto_id").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.Descripcion).HasColumnName("descripcion").HasColumnType("MEDIUMTEXT").IsRequired();
            builder.Property(x => x.Activo).HasColumnName("activo").HasColumnType("TINYINT").IsRequired();
            builder.Property(x => x.FechaRegistro).HasColumnName("fecha_registro").HasColumnType("DATETIME").IsRequired();
            builder.Property(x => x.PresupuestoControlId).HasColumnName("presupuesto_control_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.IngresoId).HasColumnName("ingreso_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Cantidad).HasColumnName("cantidad").HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(x => x.ModeloId).HasColumnName("modelo_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.InstrumentoId).HasColumnName("instrumento_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.ClienteId).HasColumnName("cliente_id").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.NombreCliente).HasColumnName("nombre_cliente").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.Precio).HasColumnName("precio").HasColumnType("DECIMAL(18,2)").IsRequired();
            builder.Property(x => x.PresupuestoItemControlId).HasColumnName("presupuesto_control_item_id").HasColumnType("INT").IsRequired();
        }
    }
}
