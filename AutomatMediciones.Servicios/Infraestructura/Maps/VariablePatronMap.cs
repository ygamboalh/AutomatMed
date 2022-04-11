using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AutomatMediciones.Servicios.Caracteristicas.Entidades;

namespace AutomatMediciones.Servicios.Infraestructura.Maps
{
    public class VariablePatronMap : IEntityTypeConfiguration<VariablePatron>
    {
        public void Configure(EntityTypeBuilder<VariablePatron> builder)
        {
            builder.ToTable("marcas");

            builder.HasKey(x => x.VariablePatronId);
            builder.Property(x => x.VariablePatronId).HasColumnName("variable_patron_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.VariableMeicionId).HasColumnName("variable_medicion_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.PatronId).HasColumnName("patron_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.ValorPatron).HasColumnName("valor_patron").HasColumnType("DECIMAL").IsRequired();
            builder.Property(x => x.Tolerancia).HasColumnName("tolerancia").HasColumnType("DECIMAL").IsRequired();
        }
    }
}
