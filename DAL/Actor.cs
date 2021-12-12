using DTO;

namespace DAL;

public class Actor
{
    public int Id { get; set; }
    public String Name { get; set; }
    public IList<Movie> Movies { get; set; }

    public Actor(string name, IList<Movie> movies)
    {
        Name = name;
        Movies = movies;
    }

    public Actor()
    {
    }

    public ActorDTO toActorDTO()
    {
        ActorDTO actorDto = new ActorDTO();
        actorDto.Id = Id;
        actorDto.Name = Name;
        actorDto.Movies = Movies.Select(movie => movie.toMovieDTO()).ToList();
        return actorDto;
    }
}