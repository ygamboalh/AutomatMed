using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class IngresoInstrumentoMap : IEntityTypeConfiguration<IngresoInstrumento>
    {
        public void Configure(EntityTypeBuilder<IngresoInstrumento> builder)
        {
            builder.ToTable("ingresos_instrumentos");

            builder.HasKey(x => x.IngresoInstrumentoId);
            builder.Property(x => x.IngresoInstrumentoId).HasColumnName("ingreso_instrumento_id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.NumeroServicioTecnico).HasColumnName("numero_servicio_tecnico").HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(x => x.IngresoId).HasColumnName("ingreso_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.InstrumentoId).HasColumnName("instrumento_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.TipoTrabajoId).HasColumnName("tipo_trabajo_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.EstadoId).HasColumnName("estado_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Prioridad).HasColumnName("prioridad").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Comentarios).HasColumnName("comentarios").HasColumnType("VARCHAR(3000)");
            builder.Property(x => x.ComentariosAcercaDelInstrumento).HasColumnName("comentarios_acerca_instrumento").HasColumnType("VARCHAR(3000)");
            builder.Property(x => x.Diagnostico).HasColumnName("diagnostico").HasColumnType("VARCHAR(3000)");
            builder.Property(x => x.FechaInicio).HasColumnName("fecha_inicio").HasColumnType("DATETIME");
            builder.Property(x => x.FechaFin).HasColumnName("fecha_fin").HasColumnType("DATETIME");
            builder.Property(x => x.FechaEntregaRequerida).HasColumnName("fecha_entrega_requerida").HasColumnType("DATETIME");
            builder.Property(x => x.TiempoConsumido).HasColumnName("tiempo_consumido").HasColumnType("TIME)");
            builder.Property(x => x.ResponsableId).HasColumnName("responsable_diagnostico_id").HasColumnType("INT");
            builder.Property(x => x.Activo).HasColumnName("activo").HasColumnType("TINYINT").IsRequired();   
        }
    }
}
