using System;

namespace _37_EightQueensProblem.Properties
{
    public class Run
    {
        private Board _board;
        private int _runCounter;  //count attempts til finish
        private int _queensCounter;
        private bool[] _usedRows;  //check if one row doesn't have more than one queen
        private static Random _rand;

        public Run()
        {
            _rand = new Random();
            _board = new Board();
            _usedRows = new bool[8];
            _runCounter = 0;
            _queensCounter = 0;
        }

        public bool IsWinner()
        {
            _board.DisplayBoard();
            Console.WriteLine();


            var attackingQueenCounter = 0;
            for (var c = 0; c < 7; c++)
            {
                for (var r = 0; r <= 7 - c; r++)
                {
                    if (_board.board[r, c + r] != Board.BoardChar)
                    {
                        attackingQueenCounter++;
                        if (!CountQueens(attackingQueenCounter))
                            return false;
                    }
                }
                attackingQueenCounter = 0;
            }

            attackingQueenCounter = 0;
            for (var r = 0; r < 7; r++)
            {
                for (var c = 7; CountQueens >= r; c--)
                {
                    if (_board.board[7 - c + r, c] != Board.BoardChar)
                    {
                        attackingQueenCounter++;
                        if (!CountQueens(attackingQueenCounter))
                            return false;
                    }
                }
                attackingQueenCounter = 0;
            }
        }


        private bool CountQueens(int attackingQueenCounter)
        {
            if (attackingQueenCounter > 1)
            {
                _queensCounter = 0;
                Array.Clear(_usedRows, 0, 8);
                _board.Init();
                return false;
            }

            return true;
        }

        public void SetPositions()
        {
            var col = 0;
            var row = 0;

            while (_queensCounter < 8)
            {
                row = _rand.Next(0, 8);
                if (IsValidRow(row))
                {
                    _board.board[row, col] = Board.QueenChar;
                    col++;
                    _queensCounter++;
                }
            }
            _runCounter++;
        }

        public bool IsValidRow(int row)
        {
            if (!_usedRows[row])
            {
                _usedRows[row] = true;
                return true;
            }

            return false;
        }


    }
}
