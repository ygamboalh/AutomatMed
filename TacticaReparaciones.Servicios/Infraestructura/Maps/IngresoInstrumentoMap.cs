using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TacticaReparaciones.Servicios.Caracteristicas.Entidades;

namespace TacticaReparaciones.Servicios.Infraestructura.Maps
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

            builder.HasOne(x => x.Instrumento).WithMany(x => x.IngresosInstrumentos).HasForeignKey(x => x.InstrumentoId);
            builder.HasOne(x => x.Ingreso).WithMany(x => x.IngresosInstrumentos).HasForeignKey(x => x.IngresoId);
        }
    }
}
