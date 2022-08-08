using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
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
            builder.Property(x => x.FechaCaducidad).HasColumnName("fecha_caducidad").HasColumnType("DATETIME").IsRequired();
            builder.Property(x => x.Fecha).HasColumnName("fecha").HasColumnType("DATETIME").IsRequired();
            builder.Property(x => x.ResponsableId).HasColumnName("responsable_id").HasColumnType("INT");
            builder.Property(x => x.CondicionesAmbientales).HasColumnName("condiciones_ambientales").HasColumnType("VARCHAR(45)");
            builder.Property(x => x.Resultado).HasColumnName("resultado").HasColumnType("VARCHAR(3000)");
            builder.Property(x => x.Observaciones).HasColumnName("observaciones").HasColumnType("VARCHAR(3000)");
            builder.Property(x => x.RutaCertificado).HasColumnName("ruta_certificado").HasColumnType("VARCHAR(100)");

            builder.HasMany(x => x.VariablesCertificado).WithOne(x => x.Certificado).HasForeignKey(x => x.CertificadoId);
        }
    }
}
