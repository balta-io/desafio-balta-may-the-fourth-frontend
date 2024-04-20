

public interface IPlanetsService
{
    public Task<Planet?> GetPlanetAsync(string planetId);
    public Task<IEnumerable<Planet>> ListPlanetsAsync(int? page = null, int? pageSize = null);
}
