using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCorePeliculas.Entidades.Configuraciones;

public class ActorMap : IEntityTypeConfiguration<Actor>
{
    public void Configure(EntityTypeBuilder<Actor> builder)
    {
        builder.Property(prop => prop.Nombre)
            .HasMaxLength(150)
            .IsRequired();

        /*
         * Si queremos nosotros sobrescribir nuestra convencion podemos hacerlo de la siguiente manera
         */
        // modelBuilder.Entity<Actor>().Property(P => P.FechaNacimiento)
        //     .HasColumnType("datetime2");
    }
}