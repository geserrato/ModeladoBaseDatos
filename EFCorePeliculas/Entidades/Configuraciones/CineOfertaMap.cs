using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCorePeliculas.Entidades.Configuraciones;

public class CineOfertaMap : IEntityTypeConfiguration<CineOferta>
{
    public void Configure(EntityTypeBuilder<CineOferta> builder)
    {
        builder.Property(P => P.PorcentajeDescuento).HasPrecision(precision: 5, scale: 2);
        // modelBuilder.Entity<CineOferta>().Property(p => p.FechaInicio).HasColumnType("date");
        // modelBuilder.Entity<CineOferta>().Property(p => p.FechaFin).HasColumnType("date");
    }
}