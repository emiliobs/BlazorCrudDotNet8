using BlazorCrudDotNet8.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrudDotNet8.Shared.Services
{

    public class ClientGameService : IGameService
    {
        private readonly HttpClient _httpClient;

        public ClientGameService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<Game> AddGame(Game game)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/games", game);

            return await result.Content.ReadFromJsonAsync<Game>();

        }

        public Task<List<Game>> GetAllGames()
        {
            throw new NotImplementedException();
        }
    }
}
