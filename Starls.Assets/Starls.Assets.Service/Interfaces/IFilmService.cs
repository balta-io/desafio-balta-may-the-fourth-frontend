using Starls.Assets.DTO;

namespace Starls.Assets.Service.Interfaces
{
    public interface IFilmService
    {
        Task<PagedContent<Film>> GetFilmsAsync(int page = 0);
    }
}