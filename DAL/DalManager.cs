using DTO;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class DalManager
{
    private MoviesContext _moviesContext = new();

    public DalManager()
    {
        _moviesContext.Database.EnsureDeleted();
        _moviesContext.Database.EnsureCreated();
    }

    public void InsertMovie(MovieDTO movieDto)
    {
        Movie movie = new();
        
        if (movieDto.Id != 0)
        {
            movie.Id = movieDto.Id;
        }

        movie.Title = movieDto.Title;
        // TODO : Note that the movies are not copied here yet. The relationship is therefore unidirectional.
        foreach (ActorDTO actorDto in movieDto.Actors)
        {
            Actor actor = new();
            actor.Id = actorDto.Id;
            actor.Name = actorDto.Name;
        }

        _moviesContext.Movies.Add(movie);
        _moviesContext.SaveChanges();
    }

    public IQueryable<MovieDTO> GetMovies()
    {
        return _moviesContext.Movies.Select(movie =>
            new MovieDTO(movie.Id, movie.Title, movie.Actors.Select(actor => actor.ToActorDto()).ToList()));
    }
}