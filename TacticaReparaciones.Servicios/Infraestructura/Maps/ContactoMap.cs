using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AutomatMediciones.Servicios.Caracteristicas.Entidades;

namespace AutomatMediciones.Servicios.Infraestructura.Maps
{
    public class ContactoMap : IEntityTypeConfiguration<Contacto>
    {
        public void Configure(EntityTypeBuilder<Contacto> builder)
        {
            builder.ToTable("contactos");

            builder.HasKey(x => x.ContactoId);
            builder.Property(x => x.ContactoId).HasColumnName("IDContacto").HasColumnType("VARCHAR(12)").IsRequired();
            builder.Property(x => x.EmpresaId).HasColumnName("IDEmpresa").HasColumnType("VARCHAR(12)").IsRequired();
            builder.Property(x => x.Cargo).HasColumnName("Cargo").HasColumnType("VARCHAR(255)");
            builder.Property(x => x.Nombre).HasColumnName("Nombre").HasColumnType("VARCHAR(255)");
        }
    }
}
