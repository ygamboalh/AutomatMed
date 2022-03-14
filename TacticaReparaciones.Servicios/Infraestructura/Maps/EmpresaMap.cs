using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TacticaReparaciones.Servicios.Caracteristicas.Entidades;

namespace TacticaReparaciones.Servicios.Infraestructura.Maps
{
    public class EmpresaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("empresas");

            builder.HasKey(x => x.EmpresaId);
            builder.Property(x => x.EmpresaId).HasColumnName("IDEmpresa").HasColumnType("VARCHAR(12)").IsRequired();
            builder.Property(x => x.NombreEmpresa).HasColumnName("Empresa").HasColumnType("VARCHAR(255)");
        }
    }
}
