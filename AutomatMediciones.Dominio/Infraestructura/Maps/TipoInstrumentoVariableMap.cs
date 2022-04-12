using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AutomatMediciones.Dominio.Caracteristicas.Entidades;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class TipoInstrumentoVariableMap : IEntityTypeConfiguration<TipoInstrumentoVariable>
    {
        public void Configure(EntityTypeBuilder<TipoInstrumentoVariable> builder)
        {
            builder.ToTable("tipos_de_instrumentos_variable");

            builder.HasKey(x => x.TipoInstrumentoVariableId);
            builder.Property(x => x.TipoInstrumentoVariableId).HasColumnName("tipo_instrumento_variable_id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.TipoInstrumentoId).HasColumnName("tipo_instrumento_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.VariableMedicionId).HasColumnName("variable_medicion_id").HasColumnType("INT").IsRequired();

            builder.HasOne(x => x.VariableDeMedicion).WithMany(x => x.TiposDeInstrumentoVariables).HasForeignKey(x => x.VariableMedicionId);
            builder.HasOne(x => x.TipoInstrumento).WithMany(x => x.TiposDeInstrumentoVariables).HasForeignKey(x => x.TipoInstrumentoId);
        }
    }
}
