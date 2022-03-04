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
            builder.Property(x => x.EmpresaId).HasColumnName("IDEmpresa").ValueGeneratedOnAdd();
            builder.Property(x => x.NombreEmpresa).HasColumnName("Empresa").HasMaxLength(255);
        }
    }
}
