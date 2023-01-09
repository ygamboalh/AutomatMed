using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    internal class MenuMap : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("menu_sistema");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.Descripcion).HasColumnName("descripcion").HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(x => x.Activo).HasColumnName("activo").HasColumnType("TINYINT").IsRequired().IsRequired();
            builder.Property(x => x.FechaAgrega).HasColumnName("fecha_agrega").HasColumnType("DATETIME").IsRequired();
            builder.Property(x => x.Icono).HasColumnName("icono").HasColumnType("VARCHAR(50)");
            builder.Property(x => x.Posicion).HasColumnName("posicion").HasColumnType("INT").IsRequired();
            builder.Property(x => x.MenuPadre).HasColumnName("menu_padre").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Color).HasColumnName("color").HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(x => x.IndiceMenu).HasColumnName("indice_menu").HasColumnType("INT").IsRequired();

            builder.HasMany(x => x.Items).WithOne(x => x.Padre).HasForeignKey(x => x.MenuPadre);
        }
    }
}
