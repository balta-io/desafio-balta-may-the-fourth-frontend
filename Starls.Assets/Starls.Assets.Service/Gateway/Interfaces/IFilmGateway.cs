using Starls.Assets.DTO;

namespace Starls.Assets.Service.Gateway.Interfaces;

public interface IFilmGateway
{
    Task<PagedContent<Film>> GetFilmsAsync(int page = 0);
}