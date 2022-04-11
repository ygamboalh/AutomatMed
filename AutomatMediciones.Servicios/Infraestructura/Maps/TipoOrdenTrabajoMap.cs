using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AutomatMediciones.Servicios.Caracteristicas.Entidades;

namespace AutomatMediciones.Servicios.Infraestructura.Maps
{
    public class TipoOrdenTrabajoMap : IEntityTypeConfiguration<TipoOrdenTrabajo>
    {
        public void Configure(EntityTypeBuilder<TipoOrdenTrabajo> builder)
        {
            builder.ToTable("tipo_orden_trabajo");

            builder.HasKey(x => x.TipoOrdenTrabajoId);
            builder.Property(x => x.TipoOrdenTrabajoId).HasColumnName("tipo_orden_trabajo_id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.Descripcion).HasColumnName("descripcion").HasColumnType("VARCHAR(50)").IsRequired();
        }
    }
}
