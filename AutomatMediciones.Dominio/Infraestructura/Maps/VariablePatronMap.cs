using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class VariablePatronMap : IEntityTypeConfiguration<VariablePatron>
    {
        public void Configure(EntityTypeBuilder<VariablePatron> builder)
        {
            builder.ToTable("variables_patrones");

            builder.HasKey(x => x.VariablePatronId);
            builder.Property(x => x.VariablePatronId).HasColumnName("variable_patron_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.VariableMeicionId).HasColumnName("variable_medicion_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.PatronId).HasColumnName("patron_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.ValorPatron).HasColumnName("valor_patron").HasColumnType("DECIMAL").IsRequired();
            builder.Property(x => x.Tolerancia).HasColumnName("tolerancia").HasColumnType("DECIMAL").IsRequired();
            builder.Property(x => x.Activo).HasColumnName("activo").HasColumnType("TINYINT").IsRequired();

            builder.HasOne(x => x.Patron).WithMany(x => x.VariablesPatrones).HasForeignKey(x => x.PatronId);
            builder.HasOne(x => x.VariableDeMedicion).WithMany(x => x.VariablesPatrones).HasForeignKey(x => x.VariableMeicionId);
        }
    }
}
