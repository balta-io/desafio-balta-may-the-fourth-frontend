public interface IMoviesService
{

    public Task<Movie?> GetMovieAsync(string movieId);
    public Task<IEnumerable<Movie>> ListMoviesAsync(int? page = null, int? pageSize = null);
}
