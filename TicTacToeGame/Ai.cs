using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class Ai : Board
    {
        public void AiSelect(string[,] board)
        {
            Random random = new Random();

            while(true)
            {
                int aiYPos = random.Next(0, 2);
                int aiXPos = random.Next(0, 2);

                if (board[aiYPos, aiXPos] != "  ")
                {
                    continue;
                }
                else
                {
                    _yPos = aiYPos;
                    _xPos = aiXPos;
                    break;
                }
            }
            _pattern = "○";
        }

        public override void Action(string[,] board)
        {
            base.Action(board);
        }
    }
}
