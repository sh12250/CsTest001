using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class GameManager : Board
    {
        public bool CheckUserWin(string[,] board)
        {
            if (board[0, 2] == "Ⅹ")
            {
                if (board[0, 0] == "Ⅹ" && board[0, 1] == "Ⅹ")
                {
                    return true;
                }
                else if (board[0, 0] == "Ⅹ" && board[1, 0] == "Ⅹ")
                {
                    return true;
                }
            }
            if (board[1, 1] == "Ⅹ")
            {
                if (board[0, 0] == "Ⅹ" && board[2, 2] == "Ⅹ")
                {
                    return true;
                }
                else if (board[1, 0] == "Ⅹ" && board[1, 2] == "Ⅹ")
                {
                    return true;
                }
                else if (board[0, 1] == "Ⅹ" && board[2, 1] == "Ⅹ")
                {
                    return true;
                }
                else if (board[0, 2] == "Ⅹ" && board[2, 0] == "Ⅹ")
                {
                    return true;
                }
            }
            if (board[2, 2] == "Ⅹ")
            {
                if (board[2, 0] == "Ⅹ" && board[2, 1] == "Ⅹ")
                {
                    return true;
                }
                else if (board[0, 2] == "Ⅹ" && board[1, 2] == "Ⅹ")
                {
                    return true;
                }
            }

            return false;
        }               // CheckUserWin()
        public bool CheckAiWin(string[,] board)
        {
            if (board[0, 2] == "○")
            {
                if (board[0, 0] == "○" && board[0, 1] == "○")
                {
                    return true;
                }
                else if (board[0, 0] == "○" && board[1, 0] == "○")
                {
                    return true;
                }
            }
            if(board[1, 1] == "○")
            {
                if (board[0, 0] == "○" && board[2, 2] == "○")
                {
                    return true;
                }
                else if (board[1, 0] == "○" && board[1, 2] == "○")
                {
                    return true;
                }
                else if (board[0, 1] == "○" && board[2, 1] == "○")
                {
                    return true;
                }
                else if (board[0, 2] == "○" && board[2, 0] == "○")
                {
                    return true;
                }
            }
            if (board[2, 2] == "○")
            {
                if (board[2, 0] == "○" && board[2, 1] == "○")
                {
                    return true;
                }
                else if (board[0, 2] == "○" && board[1, 2] == "○")
                {
                    return true;
                }
            }

            return false;
        }               // CheckAiWin()

        public bool CheckBoardFull(string[,] board)
        {
            int boardFilled = 0;

            for(int y = 0; y < board.GetLength(0); y++)
            {
                for(int x = 0; x < board.GetLength(1); x++)
                {
                    if (board[y, x] != "  ")
                    {
                        boardFilled++;
                    }
                }
            }

            if(boardFilled == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
