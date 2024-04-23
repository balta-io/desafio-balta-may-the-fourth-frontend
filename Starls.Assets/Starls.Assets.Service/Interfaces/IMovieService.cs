using Starls.Assets.DTO;

namespace Starls.Assets.Service.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetMoviesAsync(int page = 0);
    }
}