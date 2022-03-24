using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCorePeliculas.Entidades.Configuraciones;

public class PeliculaMap : IEntityTypeConfiguration<Pelicula>
{
    public void Configure(EntityTypeBuilder<Pelicula> builder)
    {
        builder.Property(p => p.Titulo).HasMaxLength(150).IsRequired();
        builder.Property(p => p.PosterUrl).HasMaxLength(500).IsUnicode(false);
    }
}