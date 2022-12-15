using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class MonedaCotizacionMap : IEntityTypeConfiguration<MonedaCotizacion>
    {
        public void Configure(EntityTypeBuilder<MonedaCotizacion> builder)
        {
            builder.ToTable("monedacotizaciones");

            builder.HasKey(x => x.RecId);
            builder.Property(x => x.RecId).HasColumnName("RecID").HasColumnType("VARCHAR(12)");
            builder.Property(x => x.CotizacionMonedaDos).HasColumnName("CotMoneda2").HasColumnType("double");
            builder.Property(x => x.CotizacionMonedaTres).HasColumnName("CotMoneda3").HasColumnType("double");
            builder.Property(x => x.CotizacionMonedaCuatro).HasColumnName("CotMoneda4").HasColumnType("double");
            builder.Property(x => x.CotizacionMonedaCinco).HasColumnName("CotMoneda5").HasColumnType("double");
            builder.Property(x => x.CotizacionMonedaSeis).HasColumnName("CotMoneda6").HasColumnType("double");
            builder.Property(x => x.FechaHora).HasColumnName("FechaHora").HasColumnType("datetime");
            builder.Property(x => x.Tipo).HasColumnName("Tipo").HasColumnType("tinyint");
            builder.Property(x => x.IdUsuario).HasColumnName("IDUsuario").HasColumnType("varchar(12)");
        }
    }
}
