using Starls.Assets.DTO;
using Starls.Assets.Service.Gateway.Interfaces;
using Starls.Assets.Service.Interfaces;

namespace Starls.Assets.Service
{
    public class FilmService : IFilmService
    {
        private readonly IFilmGateway filmGateway;

        public FilmService(IFilmGateway filmGateway)
        {
            this.filmGateway = filmGateway;
        }

        public async Task<PagedContent<Film>> GetFilmsAsync(int page = 0)
        {
            var result = await this.filmGateway.GetFilmsAsync(page);

            return result;
        }
    }
}