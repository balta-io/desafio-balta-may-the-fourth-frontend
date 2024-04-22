using Starls.Assets.DTO;
using Starls.Assets.Service.Gateway.Interfaces;

namespace Starls.Assets.Service.Gateway
{
    internal class MovieGateway : IMovieGateway
    {
        public Task<IEnumerable<Movie>> GetMoviesAsync(int page = 0)
        {
            throw new NotImplementedException("External API need to be consumed");
        }
    }
}