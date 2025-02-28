using Microsoft.AspNetCore.Mvc;
using TicTacToe.Core.Interfaces;
using TicTacToe.Core.Models;
using TicTacToe.Core.Services;

namespace TicTacToe.Web.Controllers;

public class GameController : Controller
{
    private readonly IGameRepository _gameRepository;

    public GameController(IGameRepository gameRepository)
    {
        _gameRepository = gameRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Start1()
    {
        return View();
    }

    public IActionResult Start2()
    {
        return View();
    }

    public IActionResult Choose()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateGame(bool isVsAI)
    {
        var game = new Game
        {
            IsVsAI = isVsAI
        };

        int gameId = await _gameRepository.CreateAsync(game);
        return RedirectToAction(nameof(Play), new { id = gameId });
    }

    public async Task<IActionResult> Play(int id)
    {
        var game = await _gameRepository.GetByIdAsync(id);
        if (game == null)
            return NotFound();

        return View(game);
    }

    [HttpPost]
    public async Task<IActionResult> MakeMove([FromBody] MoveRequest move)
    {
        if (move == null)
            return BadRequest();

        var game = await _gameRepository.GetByIdAsync(move.GameId);
        if (game == null || game.IsComplete || move.Row < 0 || move.Row >= 3 || move.Col < 0 || move.Col >= 3)
            return BadRequest();

        var ticTacToe = new TicTacToeService(game);
        if (!ticTacToe.MakeMove(move.Row, move.Col))
            return BadRequest();

        game.BoardState = ticTacToe.BoardState;
        game.CurrentPlayer = ticTacToe.CurrentPlayer;

        List<int> winningCells = ticTacToe.CheckWin();

        if (winningCells.Count > 0)
        {
            game.IsComplete = true;
            game.Winner = (game.CurrentPlayer == 'X' ? 'O' : 'X').ToString();
        }
        else if (ticTacToe.IsBoardFull())
        {
            game.IsComplete = true;
        }

        await _gameRepository.UpdateAsync(game);

        return Json(new
        {
            boardState = game.BoardState,
            currentPlayer = game.CurrentPlayer,
            isComplete = game.IsComplete,
            winner = game.Winner,
            winningCells = winningCells
        });
    }

    [HttpPost]
    public async Task<IActionResult> MakeAIMove([FromBody] MoveRequest move)
    {
        var game = await _gameRepository.GetByIdAsync(move.GameId);
        if (game == null || game.IsComplete)
            return BadRequest();

        var ticTacToe = new TicTacToeService(game);
        var aiMove = ticTacToe.GetAIMove();
        if (!ticTacToe.MakeMove(aiMove.row, aiMove.col))
            return BadRequest();

        game.BoardState = ticTacToe.BoardState;
        game.CurrentPlayer = ticTacToe.CurrentPlayer;

        var winningCells = ticTacToe.CheckWin();
        if (winningCells.Count > 0)
        {
            game.IsComplete = true;
            game.Winner = (game.CurrentPlayer == 'X' ? 'O' : 'X').ToString();
        }
        else if (ticTacToe.IsBoardFull())
        {
            game.IsComplete = true;
        }

        await _gameRepository.UpdateAsync(game);

        return Json(new
        {
            boardState = game.BoardState,
            currentPlayer = game.CurrentPlayer,
            isComplete = game.IsComplete,
            winner = game.Winner,
            winningCells = winningCells
        });
    }

    public class MoveRequest
    {
        public int GameId { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
    }
}
