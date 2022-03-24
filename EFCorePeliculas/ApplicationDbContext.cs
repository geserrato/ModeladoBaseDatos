using EFCorePeliculas.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EFCorePeliculas;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Genero>().HasKey(prop => prop.Identificador);
        modelBuilder.Entity<Genero>().Property(prop => prop.Nombre)
            .HasMaxLength(150)
            .IsRequired();

        modelBuilder.Entity<Actor>().Property(prop => prop.Nombre)
            .HasMaxLength(150)
            .IsRequired();
        modelBuilder.Entity<Actor>().Property(P => P.FechaNacimiento)
            .HasColumnType("date");

        modelBuilder.Entity<Cine>().Property(P => P.Nombre)
            .HasMaxLength(150)
            .IsRequired();

        modelBuilder.Entity<Cine>().Property(p => p.Precio)
            .HasPrecision(precision: 9, scale: 2);
    }

    public DbSet<Genero> Generos { get; set; }
    public DbSet<Actor> Actors { get; set; }
    public DbSet<Cine> Cines { get; set; }
}