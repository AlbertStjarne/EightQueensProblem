using System;

namespace _37_EightQueensProblem.Properties
{
    public class Board
    {
        public const char BoardChar = '.';
        public const char QueenChar = 'X';
        public char[,] board;

        public Board()
        {
            board = new char[8, 8];
        }

        public void DisplayBoard()
        {
            for (var i = 0; i < 8; i++)
            {
                for (var c = 0; c < 8; c++)
                {
                    Console.Write(board[i, c] + "  ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public void Init()
        {
            for (var i = 0; i < 8; i++)
            {
                for (var c = 0; c < 8; c++)
                {
                    board[i, c] = BoardChar;
                }
            }
        }


    }
}
