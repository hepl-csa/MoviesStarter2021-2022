namespace DTO;

public class ActorDTO
{
    public int Id { get; set; }
    public String Name { get; set; }
    public IList<MovieDTO> Movies { get; set; }

    public ActorDTO(int id, string name, IList<MovieDTO> movies)
    {
        Id = id;
        Name = name;
        Movies = movies;
    }

    public ActorDTO()
    {
    }
    
}