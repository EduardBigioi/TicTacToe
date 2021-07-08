using System;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        int[,] board = new int[Ct.BoardSize, Ct.BoardSize];
        int currentPlayer;
        public void Start()
        {
            InitBoard();
            currentPlayer = Ct.FirstPlayer;
        }

        private void InitBoard()
        {
            for (int i = 0; i < Ct.BoardSize; i++)
            {
                for (int j = 0; j < Ct.BoardSize; j++)
                {
                    board[i, j] = Ct.FreeCell;
                }
            }
        }
    }
}