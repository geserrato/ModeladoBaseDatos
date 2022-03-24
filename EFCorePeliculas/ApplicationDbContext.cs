using System.Reflection;
using EFCorePeliculas.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EFCorePeliculas;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    /*
     * override el siguinte metodo podemos agregar convenciones a nuestro mapeo de entidades
     * indicando que alguna propiedad sea de determinado tipo por ejemplo. Aquellas entidades
     * de tipo DateTime, le estaremos indiciando que sean de solo tipo Date
     */
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<DateTime>().HaveColumnType("date");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<Genero> Generos { get; set; }
    public DbSet<Actor> Actors { get; set; }
    public DbSet<Cine> Cines { get; set; }
    public DbSet<Pelicula> Peliculas { get; set; }
    public DbSet<CineOferta> CineOfertas { get; set; }
    public DbSet<SalaDeCine> SalaDeCines { get; set; }
    public DbSet<PeliculaActor> PeliculaActores { get; set; }
}