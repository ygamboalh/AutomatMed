using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AutomatMediciones.Dominio.Caracteristicas.Entidades;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class VariableInstrumentoMap : IEntityTypeConfiguration<VariableInstrumento>
    {
        public void Configure(EntityTypeBuilder<VariableInstrumento> builder)
        {
            builder.ToTable("variables_instrumentos");

            builder.HasKey(x => x.VariableInstrumentoId);
            builder.Property(x => x.VariableInstrumentoId).HasColumnName("variable_instrumento_id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.VariableMedicionId).HasColumnName("variable_medicion_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.InstrumentoId).HasColumnName("instrumento_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.TieneAlarma).HasColumnName("tiene_alarma").HasColumnType("TINYINT").IsRequired();
            builder.Property(x => x.AlarmaBaja).HasColumnName("alarma_baja").HasColumnType("DECIMAL");
            builder.Property(x => x.AlarmaAlta).HasColumnName("alarma_alta").HasColumnType("DECIMAL");
            builder.Property(x => x.AlarmaStel).HasColumnName("alarma_stel").HasColumnType("DECIMAL");
            builder.Property(x => x.AlarmaTwa).HasColumnName("alarma_twa").HasColumnType("DECIMAL");
        }
    }
}
