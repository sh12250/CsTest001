using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class User : Board
    {

        public void UserSelet(int xPos, int yPos) 
        {
            _yPos = yPos;
            _xPos = xPos;
            _pattern = "Ⅹ";
        }

        public override void Action(string[,] board)
        {
            base.Action(board);
        }
    }
}
