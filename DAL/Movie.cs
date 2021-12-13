using DTO;

namespace DAL;

public class Movie
{
    public int Id { get; set; }
    public String Title { get; set; }

    public IList<Actor> Actors { get; set; }


    public Movie(string title, IList<Actor> actors)
    {
        Title = title;
        Actors = actors;
        Actors = actors;
    }

    public Movie()
    {
    }

    public MovieDTO ToMovieDto()
    {
        MovieDTO movieDto = new MovieDTO
        {
            Id = Id,
            Title = Title,
            Actors = Actors.Select(actor => actor.ToActorDto()).ToList()
        };

        return movieDto;
    }
}