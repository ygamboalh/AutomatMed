using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AutomatMediciones.Servicios.Caracteristicas.Entidades;

namespace AutomatMediciones.Servicios.Infraestructura.Maps
{
    public class CorreoElectronicoMap : IEntityTypeConfiguration<CorreoElectronico>
    {
        public void Configure(EntityTypeBuilder<CorreoElectronico> builder)
        {
            builder.ToTable("direccionescorreo");

            builder.HasKey(x => x.RegistroId);
            builder.Property(x => x.RegistroId).HasColumnName("RecID").HasColumnType("VARCHAR(12)").IsRequired();
            builder.Property(x => x.ContactoId).HasColumnName("IDref").HasColumnType("VARCHAR(12)").IsRequired();
            builder.Property(x => x.Direccion).HasColumnName("Direccion").HasColumnType("VARCHAR(255)");
        }
    }
}
