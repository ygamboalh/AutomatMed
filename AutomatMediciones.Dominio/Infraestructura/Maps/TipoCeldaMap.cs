using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    class TipoCeldaMap : IEntityTypeConfiguration<TipoCelda>
    {
        public void Configure(EntityTypeBuilder<TipoCelda> builder)
        {
            builder.ToTable("tipos_celda");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.VariableMedicionId).HasColumnName("variable_medicion_id").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Descripcion).HasColumnName("descripcion").HasColumnType("VARCHAR(45)").IsRequired();

            //builder.HasOne(x => x.VariableDeMedicion).WithMany(x => x.TiposDeCeldas).HasForeignKey(x => x.VariableMedicionId);
            //builder.HasMany(x => x.TiposDeCeldaModelo).WithOne(x => x.TipoDeCelda).HasForeignKey(x => x.TipoCeldaId);
        }
    }
}
