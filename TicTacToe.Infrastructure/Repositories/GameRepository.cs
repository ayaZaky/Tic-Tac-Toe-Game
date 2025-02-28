using Microsoft.EntityFrameworkCore;
using TicTacToe.Core.Models;
using TicTacToe.Core.Interfaces;
using TicTacToe.Infrastructure.Data;
using System;

namespace TicTacToe.Infrastructure.Repositories;

public class GameRepository : IGameRepository
{
    private readonly ApplicationDbContext _context;

    public GameRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> CreateAsync(Game game)
    {
        _context.Games.Add(game);
        await _context.SaveChangesAsync();
        return game.Id;
    }

    public async Task<List<Game>> GetAllAsync()
    {
        return await _context.Games.ToListAsync();
    }

    public async Task<Game> GetByIdAsync(int id)
    {
        return await _context.Games.FindAsync(id);
    }

    public async Task UpdateAsync(Game game)
    {
        _context.Games.Update(game);
        await _context.SaveChangesAsync();
    }
}