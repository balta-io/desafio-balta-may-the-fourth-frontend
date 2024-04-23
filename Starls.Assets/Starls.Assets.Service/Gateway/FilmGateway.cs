using Starls.Assets.DTO;
using Starls.Assets.DTO.Configuration;
using Starls.Assets.Service.Gateway.Extensions;
using Starls.Assets.Service.Gateway.Interfaces;
using Api = Starls.Assets.Service.Gateway.ApiResponseModel;

namespace Starls.Assets.Service.Gateway
{
    public class FilmGateway : BaseGateway, IFilmGateway
    {
        private readonly ProviderConfiguration FilmProviderConfiguration;

        public FilmGateway(IHttpClientFactory httpClientFactory, AppConfiguration appConfiguration) :
            base(httpClientFactory, appConfiguration.FilmProviderConfiguration.Name)
        {
            this.FilmProviderConfiguration = appConfiguration.FilmProviderConfiguration;
        }

        public async Task<PagedContent<Film>> GetFilmsAsync(int page = 0)
        {
            var urlPath = this.GetApiResourcePath(this.FilmProviderConfiguration.Resource, page);

            var result = await this.GetPagedAsync<Api.Film>(urlPath);

            return result.ToDto();
        }
    }
}