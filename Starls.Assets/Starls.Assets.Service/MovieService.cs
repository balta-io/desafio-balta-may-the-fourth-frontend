using Starls.Assets.DTO;
using Starls.Assets.Service.Gateway.Interfaces;
using Starls.Assets.Service.Interfaces;

namespace Starls.Assets.Service
{
    public class MovieService : IMovieService
    {
        private readonly IMovieGateway movieGateway;

        internal MovieService(IMovieGateway movieGateway)
        {
            this.movieGateway = movieGateway;
        }

        public async Task<IEnumerable<Movie>> GetMoviesAsync(int page = 0)
        {
            var result = await this.movieGateway.GetMoviesAsync(page);

            return result;
        }
    }
}