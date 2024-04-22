using Starls.Assets.DTO;

namespace Starls.Assets.Service.Gateway.Interfaces;

internal interface IMovieGateway
{
    Task<IEnumerable<Movie>> GetMoviesAsync(int page = 0);
}