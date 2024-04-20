using MyTheFourth.Frontend.Web.Models;

namespace MyTheFourth.Frontend.Web.Client.Services.Interfaces;

public interface IPlanetsService
{
    public Task<Planet?> GetPlanetAsync(string planetId);
    public Task<IEnumerable<Planet>> ListPlanetsAsync(int? page = null, int? pageSize = null);
}