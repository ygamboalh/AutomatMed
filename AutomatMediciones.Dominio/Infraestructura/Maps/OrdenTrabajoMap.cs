using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class OrdenTrabajoMap : IEntityTypeConfiguration<OrdenTrabajo>
    {
        public void Configure(EntityTypeBuilder<OrdenTrabajo> builder)
        {
            builder.ToTable("orden_de_trabajo");

            builder.HasKey(x => x.OrdenTrabajoId);
            builder.Property(x => x.OrdenTrabajoId).HasColumnName("orden_trabajo_id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.IngresoInstrumentoId).HasColumnName("ingreso_instrumento_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.TipoOrdenTrabajoId).HasColumnName("tipo_orden_trabajo_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Prioridad).HasColumnName("prioridad").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Comentarios).HasColumnName("comentarios").HasColumnType("VARCHAR(500)");
            builder.Property(x => x.FechaInicio).HasColumnName("fecha_inicio").HasColumnType("DATETIME").IsRequired();
            builder.Property(x => x.FechaFin).HasColumnName("fecha_fin").HasColumnType("DATETIME");
            builder.Property(x => x.TiempoConsumido).HasColumnName("tiempo_consumido").HasColumnType("DECIMAL");
            builder.Property(x => x.Activo).HasColumnName("activo").HasColumnType("TINYINT").IsRequired();
            builder.Property(x => x.EstadoOrdenTrabajoId).HasColumnName("estado_orden_trabajo_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.TiempoEstimado).HasColumnName("tiempo_estimado").HasColumnType("DECIMAL");
            builder.Property(x => x.Diagnostico).HasColumnName("diagnostico").HasColumnType("VARCHAR(500)");
        }
    }
}
