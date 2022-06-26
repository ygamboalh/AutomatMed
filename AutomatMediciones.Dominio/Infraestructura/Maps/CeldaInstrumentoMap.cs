using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class CeldaInstrumentoMap : IEntityTypeConfiguration<CeldaInstrumento>
    {
        public void Configure(EntityTypeBuilder<CeldaInstrumento> builder)
        {
            builder.ToTable("celdas_instrumentos");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.InstrumentoId).HasColumnName("instrumento_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.CeldaId).HasColumnName("celda_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.FechaColocacion).HasColumnName("fecha_colocacion").HasColumnType("DATETIME");
            builder.Property(x => x.FechaExtraccion).HasColumnName("fecha_extraccion").HasColumnType("DATETIME");
        }
    }
}
