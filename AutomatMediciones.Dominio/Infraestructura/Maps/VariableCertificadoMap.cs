using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class VariableCertificadoMap : IEntityTypeConfiguration<VariableCertificado>
    {
        public void Configure(EntityTypeBuilder<VariableCertificado> builder)
        {
            builder.ToTable("variables_certificados");

            builder.HasKey(x => x.VariableCertificadoId);
            builder.Property(x => x.VariableCertificadoId).HasColumnName("variable_certificado_id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.CertificadoId).HasColumnName("certificado_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.PatronId).HasColumnName("patron_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.ValorMedido).HasColumnName("valor_medido").HasColumnType("DECIMAL").IsRequired();
            builder.Property(x => x.VariableInstrumentoId).HasColumnName("variable_instrumento_id").HasColumnType("INT").IsRequired();
        }
    }
}
