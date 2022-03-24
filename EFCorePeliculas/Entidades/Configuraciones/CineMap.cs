using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCorePeliculas.Entidades.Configuraciones;

public class CineMap : IEntityTypeConfiguration<Cine>
{
    public void Configure(EntityTypeBuilder<Cine> builder)
    {
        builder.Property(P => P.Nombre)
            .HasMaxLength(150)
            .IsRequired();
    }
}