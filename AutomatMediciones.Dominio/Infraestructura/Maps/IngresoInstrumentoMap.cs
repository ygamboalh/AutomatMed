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
            builder.Property(x => x.IngresoId).HasColumnName("ingreso_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.InstrumentoId).HasColumnName("instrumento_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Activo).HasColumnName("activo").HasColumnType("TINYINT").IsRequired();
            builder.Property(x => x.Comentarios).HasColumnName("comentarios").HasColumnType("VARCHAR(3000)").IsRequired();
            builder.Property(x => x.NumeroServicioTecnico).HasColumnName("numero_servicio_tecnico").HasColumnType("VARCHAR(50)").IsRequired();

            builder.HasOne(x => x.Instrumento).WithMany(x => x.IngresosInstrumentos).HasForeignKey(x => x.InstrumentoId);
            builder.HasOne(x => x.Ingreso).WithMany(x => x.IngresosInstrumentos).HasForeignKey(x => x.IngresoId);
        }
    }
}
