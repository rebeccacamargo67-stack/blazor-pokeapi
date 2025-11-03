using System.Net.Http.Json;
using BuscarPokemon.Models;

namespace BuscarPokemon.Services
{
    public class PokemonService
    {
        private readonly HttpClient _http;

        public PokemonService(HttpClient http)
        {
            _http = http;
        }

        public async Task<Pokemon?> GetPokemonAsync(string nome)
        {
            try
            {
                string url = $"https://pokeapi.co/api/v2/pokemon/{nome.ToLower()}";
                return await _http.GetFromJsonAsync<Pokemon>(url);
            }
            catch
            {
                return null;
            }
        }
    }
}
