using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class Board
    {
        const int MAXSIZE = 3;
        public string[,] _gameBoard; // ○ Ⅹ 

        protected string _pattern;
        protected int _xPos;
        protected int _yPos;

        public Board()
        {
            string[,] board = new string[MAXSIZE, MAXSIZE];
            for (int y = 0; y < MAXSIZE; y++)
            {
                for(int  x = 0; x < MAXSIZE; x++) 
                {
                    board[y,x] = "  ";
                }
            }

            _gameBoard = board;
        }

        public virtual void Action(string[,] board)
        {
            board[_yPos,_xPos] = _pattern;
        }

        public void PrintTheBoard()
        {
            Console.WriteLine(_gameBoard[0, 0]+"│ "+ _gameBoard[0, 1] + "│ " + _gameBoard[0, 2]);
            Console.WriteLine("──┼───┼──");
            Console.WriteLine(_gameBoard[1, 0]+"│ "+ _gameBoard[1, 1] + "│ " + _gameBoard[1, 2]);
            Console.WriteLine("──┼───┼──");
            Console.WriteLine(_gameBoard[2, 0] + "│ " + _gameBoard[2, 1] + "│ " + _gameBoard[2, 2]);
        }
    }
}
