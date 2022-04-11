using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AutomatMediciones.Servicios.Caracteristicas.Entidades;

namespace AutomatMediciones.Servicios.Infraestructura.Maps
{
    public class CertificadoMap : IEntityTypeConfiguration<Certificado>
    {
        public void Configure(EntityTypeBuilder<Certificado> builder)
        {
            builder.ToTable("certificados");

            builder.HasKey(x => x.CertificadoId);
            builder.Property(x => x.CertificadoId).HasColumnName("certificado_id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.NumeroCertificado).HasColumnName("numero_certificado").HasColumnType("VARCHAR(45)").IsRequired();
            builder.Property(x => x.InstrumentoId).HasColumnName("instrumento_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.FechaCaducidad).HasColumnName("condiciones_ambientales").HasColumnType("VARCHAR(45)").IsRequired();
            builder.Property(x => x.Fecha).HasColumnName("tolerancia").HasColumnType("DECIMAL");
            builder.Property(x => x.Responsable).HasColumnName("responsable").HasColumnType("VARCHAR(45)");
            builder.Property(x => x.CondicionesAmbientales).HasColumnName("condiciones_ambientales").HasColumnType("VARCHAR(45)");
        }
    }
}
