using Microsoft.EntityFrameworkCore;

namespace DAL;

public class MoviesContext : DbContext
{
    public MoviesContext() : base(new DbContextOptions<MoviesContext>())
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(@"Host=localhost;Database=movies2122;Username=postgres;Password=postgres");
    }
    


    public DbSet<Actor> Actors { get; set; }
    public DbSet<Movie> Movies { get; set; }
}