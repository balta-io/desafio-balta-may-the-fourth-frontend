using MyTheFourth.Frontend.Web.Models;

namespace MyTheFourth.Frontend.Web.Services.Interfaces;

public interface IStarshipsService
{

    public Task<Starship?> GetStarshipAsync(string starshipId);
    public Task<IEnumerable<Starship>> ListStarshipsAsync(int? page = null, int? pageSize = null);
}