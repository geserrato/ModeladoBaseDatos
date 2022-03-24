using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCorePeliculas.Entidades.Configuraciones;

public class PeliculaActorMap : IEntityTypeConfiguration<PeliculaActor>
{
    public void Configure(EntityTypeBuilder<PeliculaActor> builder)
    {
        builder.HasKey(p => new { p.PeliculaId, p.ActorId });
        builder.Property(P => P.Personaje).HasMaxLength(150);
    }
}