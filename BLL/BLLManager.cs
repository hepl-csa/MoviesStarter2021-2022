using DAL;
using DTO;

namespace BLL;

public class BLLManager
{
    private DalManager _dalManager = new DalManager();

    public void InsertMovie(MovieDTO movieDto)
    {
        _dalManager.InsertMovie(movieDto);
    }

    public IQueryable<MovieDTO>? GetMovies(int from, int to, Func<MovieDTO, bool> predicate)
    {
        return GetMovies(predicate)?.Skip(from).Take(to);
    }

    public MovieDTO GetMovie(Func<MovieDTO, bool> predicate)
    {
        return _dalManager.GetMovies().FirstOrDefault(predicate);
    }

    public IQueryable<MovieDTO>? GetMovies(Func<MovieDTO, bool> predicate)
    {
        return _dalManager.GetMovies().Where(predicate) as IQueryable<MovieDTO>;
    }
}