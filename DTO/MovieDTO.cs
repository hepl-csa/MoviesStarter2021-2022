namespace DTO;

public class MovieDTO
{
    public int Id { get; set; }
    public String Title { get; set; }

    public IList<ActorDTO> Actors { get; set; }

    public MovieDTO(int id, string title, IList<ActorDTO> actors)
    {
        Id = id;
        Title = title;
        Actors = actors;
    }

    public MovieDTO(string title, IList<ActorDTO> actors)
    {
        Title = title;
        Actors = actors;
    }

    public MovieDTO()
    {
    }
}