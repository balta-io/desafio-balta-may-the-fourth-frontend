using MyTheFourth.Frontend.Web.Models;

namespace MyTheFourth.Frontend.Web.Services.Interfaces;

public interface ICharactersService
{

    public Task<Character?> GetCharacterAsync(string characterId);
    public Task<IEnumerable<Character>> ListCharactersAsync(int? page = null, int? pageSize = null);
}