using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AutomatMediciones.Servicios.Caracteristicas.Entidades;

namespace AutomatMediciones.Servicios.Infraestructura.Maps
{
    public class PatronMap : IEntityTypeConfiguration<Patron>
    {
        public void Configure(EntityTypeBuilder<Patron> builder)
        {
            builder.ToTable("patrones");

            builder.HasKey(x => x.PatronId);
            builder.Property(x => x.PatronId).HasColumnName("patron_id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.FechaCaducidad).HasColumnName("fecha_caducidad").HasColumnType("DATETIME").IsRequired();
            builder.Property(x => x.Nombre).HasColumnName("nombre").HasColumnType("VARCHAR(120)").IsRequired();
            builder.Property(x => x.Activo).HasColumnName("activo").HasColumnType("TINYINT").IsRequired();
            builder.Property(x => x.Link).HasColumnName("link").HasColumnType("VARCHAR(100)").IsRequired();
        }
    }
}
