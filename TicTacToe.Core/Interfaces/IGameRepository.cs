using TicTacToe.Core.Models;

namespace TicTacToe.Core.Interfaces;

public interface IGameRepository
{
    Task<Game> GetByIdAsync(int id);
    Task<List<Game>> GetAllAsync();
    Task<int> CreateAsync(Game game);
    Task UpdateAsync(Game game);
}
 