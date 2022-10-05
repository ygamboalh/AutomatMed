using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class PresupuestoItemMap : IEntityTypeConfiguration<PresupuestoItem>
    {
        public void Configure(EntityTypeBuilder<PresupuestoItem> builder)
        {
            builder.ToTable("presupuestositems");

            builder.HasKey(x => x.RecID);
            builder.Property(x => x.RecID).HasColumnName("RecID").HasColumnType("VARCHAR(12)").IsRequired();
            builder.Property(x => x.IDProducto).HasColumnName("IDProducto").HasColumnType("VARCHAR(12)");
            builder.Property(x => x.IDPresupuesto).HasColumnName("IDPresupuesto").HasColumnType("VARCHAR(12)");
            builder.Property(x => x.IDUsuario).HasColumnName("IDUsuario").HasColumnType("VARCHAR(12)");
            builder.Property(x => x.Cantidad).HasColumnName("Cantidad").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.CantidadCerrada).HasColumnName("CantidadCerrada").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.ImportePrecio1).HasColumnName("ImportePrecio1").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.ImportePrecio2).HasColumnName("ImportePrecio2").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.ImportePrecio3).HasColumnName("ImportePrecio3").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.ImportePrecio4).HasColumnName("ImportePrecio4").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.ImportePrecio5).HasColumnName("ImportePrecio5").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.ImportePrecio6).HasColumnName("ImportePrecio6").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.ImporteCosto1).HasColumnName("ImporteCosto1").HasColumnType("DOUBLE");
            builder.Property(x => x.ImporteCosto2).HasColumnName("ImporteCosto2").HasColumnType("DOUBLE");
            builder.Property(x => x.ImporteCosto3).HasColumnName("ImporteCosto3").HasColumnType("DOUBLE");
            builder.Property(x => x.ImporteCosto4).HasColumnName("ImporteCosto4").HasColumnType("DOUBLE");
            builder.Property(x => x.ImporteCosto5).HasColumnName("ImporteCosto5").HasColumnType("DOUBLE");
            builder.Property(x => x.ImporteCosto6).HasColumnName("ImporteCosto6").HasColumnType("DOUBLE");
            builder.Property(x => x.Probabilidad).HasColumnName("Probabilidad").HasColumnType("DOUBLE");
            builder.Property(x => x.FechaSistema).HasColumnName("FechaSistema").HasColumnType("DATETIME");
            builder.Property(x => x.FechaCierre).HasColumnName("FechaCierre").HasColumnType("DATETIME");
            builder.Property(x => x.FechaEmision).HasColumnName("FechaEmision").HasColumnType("DATETIME");
            builder.Property(x => x.IDEjercicio).HasColumnName("IDEjercicio").HasColumnType("VARCHAR(12)");
            builder.Property(x => x.IDPeriodo).HasColumnName("IDPeriodo").HasColumnType("VARCHAR(12)");
            builder.Property(x => x.Estado).HasColumnName("Estado").HasColumnType("TINYINT");
            builder.Property(x => x.Descripcion).HasColumnName("Descripcion").HasColumnType("MEDIUMTEXT");
            builder.Property(x => x.Descripcion2).HasColumnName("Descripcion2").HasColumnType("MEDIUMTEXT");
            builder.Property(x => x.Descripcion3).HasColumnName("Descripcion3").HasColumnType("MEDIUMTEXT");
            builder.Property(x => x.TipoProducto).HasColumnName("TipoProducto").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.FechaInclusion).HasColumnName("FechaInclusion").HasColumnType("DATETIME");
            builder.Property(x => x.FechaModificacion).HasColumnName("FechaModificacion").HasColumnType("DATETIME");
            builder.Property(x => x.Codigo).HasColumnName("Codigo").HasColumnType("VARCHAR(255)");
            builder.Property(x => x.Fabricante).HasColumnName("Fabricante").HasColumnType("VARCHAR(255)");
            builder.Property(x => x.Descuento).HasColumnName("Descuento").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.SobrePrecio).HasColumnName("SobrePrecio").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.NroPrecio).HasColumnName("NroPrecio").HasColumnType("TINYINT").IsRequired();
            builder.Property(x => x.IDProdOb).HasColumnName("IDProdOb").HasColumnType("VARCHAR(12)").IsRequired();
            builder.Property(x => x.ObligOp).HasColumnName("ObligOp").HasColumnType("TINYINT");
            builder.Property(x => x.NroItem).HasColumnName("NroItem").HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(x => x.PrecioOculto).HasColumnName("PrecioOculto").HasColumnType("TINYINT").IsRequired();
            builder.Property(x => x.Notas).HasColumnName("Notas").HasColumnType("MEDIUMTEXT").IsRequired();
            builder.Property(x => x.PlazoEntrega).HasColumnName("PlazoEntrega").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.FormaPago).HasColumnName("FormaPago").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.Validez).HasColumnName("Validez").HasColumnType("INT").IsRequired();
            builder.Property(x => x.NroFila).HasColumnName("NroFila").HasColumnType("INT").IsRequired();
            builder.Property(x => x.DescripcionDescuento).HasColumnName("DescripcionDescuento").HasColumnType("MEDIUMTEXT").IsRequired();
            builder.Property(x => x.Unidad).HasColumnName("Unidad").HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(x => x.TipoUnidad).HasColumnName("TipoUnidad").HasColumnType("TINYINT").IsRequired();
            builder.Property(x => x.Impuesto).HasColumnName("Impuesto").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.ImpuestoDescripcion).HasColumnName("ImpuestoDescripcion").HasColumnType("VARCHAR(255)");
            builder.Property(x => x.IDCotizacionMoneda).HasColumnName("IDCotizacionMoneda").HasColumnType("VARCHAR(12)");
            builder.Property(x => x.TipoComision).HasColumnName("TipoComision").HasColumnType("TINYINT").IsRequired();
            builder.Property(x => x.Comision).HasColumnName("Comision").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.TipoComisionTerceros).HasColumnName("TipoComisionTerceros").HasColumnType("TINYINT").IsRequired();
            builder.Property(x => x.ComisionTerceros).HasColumnName("ComisionTerceros").HasColumnType("DOUBLE").IsRequired();
            builder.Property(x => x.NroMoneda).HasColumnName("NroMoneda").HasColumnType("TINYINT");
            builder.Property(x => x.ImporteUnitario1).HasColumnName("ImporteUnitario1").HasColumnType("DOUBLE");
            builder.Property(x => x.ImporteUnitario2).HasColumnName("ImporteUnitario2").HasColumnType("DOUBLE");
            builder.Property(x => x.ImporteUnitario3).HasColumnName("ImporteUnitario3").HasColumnType("DOUBLE");
            builder.Property(x => x.ImporteUnitario4).HasColumnName("ImporteUnitario4").HasColumnType("DOUBLE");
            builder.Property(x => x.ImporteUnitario5).HasColumnName("ImporteUnitario5").HasColumnType("DOUBLE");
            builder.Property(x => x.ImporteUnitario6).HasColumnName("ImporteUnitario6").HasColumnType("DOUBLE");
            builder.Property(x => x.IDUsuarioVendedor).HasColumnName("IDUsuarioVendedor").HasColumnType("VARCHAR(12)");
            builder.Property(x => x.DescripcionGrupo).HasColumnName("DescripcionGrupo").HasColumnType("MEDIUMTEXT");
            builder.Property(x => x.NombreGrupo).HasColumnName("NombreGrupo").HasColumnType("MEDIUMTEXT");
            builder.Property(x => x.NroMonedaComisionTerceros).HasColumnName("NroMonedaComisionTerceros").HasColumnType("TINYINT");
        }
    }
}
