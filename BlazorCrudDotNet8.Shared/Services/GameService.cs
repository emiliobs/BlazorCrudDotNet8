using BlazorCrudDotNet8.Shared.Data;
using BlazorCrudDotNet8.Shared.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Shared.Services
{
    public class GameService : IGameService
    {
        public DataContext _Context { get; }
        public GameService(DataContext context)
        {
            _Context = context;
        }


        public async Task<List<Game>> GetAllGames()
        {
            return await _Context.Games.ToListAsync();
        }

        public async Task<Game> AddGame(Game game)
        {
            _Context.Games.Add(game);
            await _Context.SaveChangesAsync();

            return game;
        }
    }
}
