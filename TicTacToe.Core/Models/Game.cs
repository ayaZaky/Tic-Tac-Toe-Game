namespace TicTacToe.Core.Models;

public class Game
{
    public int Id { get; set; }
    public string BoardState { get; set; }  = new string('\0', 9);
    public char CurrentPlayer { get; set; } = 'O';
    public bool IsComplete { get; set; }
    public string? Winner { get; set; }
    public bool IsVsAI { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
}