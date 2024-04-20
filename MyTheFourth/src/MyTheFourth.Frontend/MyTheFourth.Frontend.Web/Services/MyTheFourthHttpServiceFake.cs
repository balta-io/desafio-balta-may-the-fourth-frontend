using MyTheFourth.Frontend.Web.Models;
using MyTheFourth.Frontend.Web.Services.Interfaces;

public class MyTheFourthHttpServiceFake :
IMoviesService,
ICharactersService,
IPlanetsService,
IVehiclesService,
IStarshipsService
{

    private static Movie[] _movies = [];
    private static Character[] _characters = [];
    private static Planet[] _planets = [];
    private static Vehicle[] _vehicles = [];
    private static Starship[] _starships = [];

   
    

    public async Task<Movie?> GetMovieAsync(string movieId)
    {
        await Task.Delay(Random.Shared.Next(500, 5000));

        return _movies.FirstOrDefault(x => x.Id == int.Parse(movieId));
    }

    public async Task<IEnumerable<Movie>> ListMoviesAsync(int? page = null, int? pageSize = null)
    {
        await Task.Delay(Random.Shared.Next(500, 5000));

        return _movies;
    }

    public async Task<Character?> GetCharacterAsync(string characterId)
    {
        await Task.Delay(Random.Shared.Next(500, 5000));

        return _characters.FirstOrDefault(x => x.Id == int.Parse(characterId));
    }

    public async Task<IEnumerable<Character>> ListCharactersAsync(int? page = null, int? pageSize = null)
    {
        await Task.Delay(Random.Shared.Next(500, 5000));

        return _characters;
    }

    public async Task<Planet?> GetPlanetAsync(string planetId)
    {
        await Task.Delay(Random.Shared.Next(500, 5000));

        return _planets.FirstOrDefault(x => x.Id == int.Parse(planetId));
    }

    public async Task<IEnumerable<Planet>> ListPlanetsAsync(int? page = null, int? pageSize = null)
    {
        await Task.Delay(Random.Shared.Next(500, 5000));

        return _planets;
    }

    public async Task<Vehicle?> GetVehicleAsync(string vehicleId)
    {
        await Task.Delay(Random.Shared.Next(500, 5000));

        return _vehicles.FirstOrDefault(x => x.Id == int.Parse(vehicleId));
    }

    public async Task<IEnumerable<Vehicle>> ListVehiclesAsync(int? page = null, int? pageSize = null)
    {
        await Task.Delay(Random.Shared.Next(500, 5000));

        return _vehicles;
    }
   
    public async Task<Starship?> GetStarshipAsync(string starshipId)
    {
        await Task.Delay(Random.Shared.Next(500, 5000));

        return _starships.FirstOrDefault(x => x.Id == int.Parse(starshipId));
    }

    public async Task<IEnumerable<Starship>> ListStarshipsAsync(int? page = null, int? pageSize = null)
    {
        await Task.Delay(Random.Shared.Next(500, 5000));

        return _starships;
    }

   
}
