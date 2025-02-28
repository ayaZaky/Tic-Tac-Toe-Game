using TicTacToe.Core.Models;
using TicTacToe.Core.Interfaces;

namespace TicTacToe.Core.Services
{
    public class TicTacToeService
    {
        private char[,] board = new char[3, 3];
        public char CurrentPlayer { get; private set; }
        public string BoardState
        {
            get
            {
                var result = new char[9];
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        result[i * 3 + j] = board[i, j];
                return new string(result);
            }
        }

        public TicTacToeService(Game game)
        {
            CurrentPlayer = game.CurrentPlayer;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    board[i, j] = game.BoardState[i * 3 + j];
        }

        public bool MakeMove(int row, int col)
        {
            if (row < 0 || row >= 3 || col < 0 || col >= 3 || board[row, col] != '\0')
                return false;

            board[row, col] = CurrentPlayer;
            CurrentPlayer = (CurrentPlayer == 'X') ? 'O' : 'X';
            return true;
        }

        public List<int> CheckWin()
        {
            char player = (CurrentPlayer == 'X') ? 'O' : 'X';
            List<int> winningCells = new List<int>();

            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                {
                    winningCells.Add(i * 3 + 0);
                    winningCells.Add(i * 3 + 1);
                    winningCells.Add(i * 3 + 2);
                    return winningCells;
                }
            }

            // Check columns
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == player && board[1, j] == player && board[2, j] == player)
                {
                    winningCells.Add(0 * 3 + j);
                    winningCells.Add(1 * 3 + j);
                    winningCells.Add(2 * 3 + j);
                    return winningCells;
                }
            }

            // Check diagonals
            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
            {
                winningCells.Add(0);
                winningCells.Add(4);
                winningCells.Add(8);
                return winningCells;
            }

            if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
            {
                winningCells.Add(2);
                winningCells.Add(4);
                winningCells.Add(6);
                return winningCells;
            }

            return new List<int>(); // No winner
        }

        public bool IsBoardFull()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (board[i, j] == '\0')
                        return false;
            return true;
        }

        public (int row, int col) GetAIMove()
        {
            // Take center if available
            if (board[1, 1] == '\0')
                return (1, 1);

            // Take corners
            (int, int)[] corners = { (0, 0), (0, 2), (2, 0), (2, 2) };
            foreach (var (row, col) in corners)
            {
                if (board[row, col] == '\0')
                    return (row, col);
            }

            // Take any available space
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (board[i, j] == '\0')
                        return (i, j);

            return (0, 0); // Should never reach here if board is not full
        }
    }
}